using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.ImgHash;
using Emgu.CV.Features2D;
using Emgu.CV.Flann;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Windows.Forms;
using System.IO;


namespace DuplicateDetector
{
    class FingerPrint
    {
        public long Hash { get; private set; }


        public FingerPrint(long value)
        {
            this.Hash = value;
        }


        public static FingerPrint operator ^(FingerPrint fp1, FingerPrint fp2)
        {
            return new FingerPrint(fp1.Hash ^ fp2.Hash);
        }


        public int HammingDistanceTo(FingerPrint hash2)
        {
            var binStr = Convert.ToString((this ^ hash2).Hash, 2);
            var count = binStr.Count(ch => ch == '1');

            return count;
        }
    }



    class FeatureDescriptor
    {
        public Mat Data { get; private set; }


        public FeatureDescriptor(Mat descriptor)
        {
            this.Data = descriptor;
        }


        public BitArray GetBinDescriptor()
        {
            var binDescriptor = new BitArray(Data.GetData());

            return binDescriptor;
        }
    }




    public static class MatExtention
    {
        public static Mat FormBitMat(this Mat matrix, int rows, int cols, BitArray array)
        {
            unsafe
            {
                byte *buffer = (byte *)Marshal.AllocHGlobal(rows * cols);
                for (int i = 0; i != array.Count; i++)
                {
                    buffer[i] = Convert.ToByte(array[i]);
                }

                matrix = new Mat(rows, cols, DepthType.Cv8U, 1, new IntPtr(buffer), rows);

                return matrix;
            }
        }
    }



    class DescriptorExtractor
    {
        protected readonly int matrixRows;
        protected readonly int matrixCols;


        public DescriptorExtractor(int matrixRows, int matrixCols)
        {
            this.matrixRows = matrixRows;
            this.matrixCols = matrixCols;
        }


        public List<FeatureDescriptor> ExtractDescriptors(Mat descriptors)
        {
            List<FeatureDescriptor> descriptorsList = new List<FeatureDescriptor>(descriptors.Rows);

            for (int rowNumber = 0; rowNumber != descriptors.Rows; rowNumber++)
            {
                descriptorsList.Add(new FeatureDescriptor(descriptors.Row(rowNumber)));
            }

            return descriptorsList;
        }


        public FeatureDescriptor TransformToBinSquare(FeatureDescriptor descriptor)
        {
            Mat binMat = new Mat();
            binMat = binMat.FormBitMat(matrixRows, matrixCols, descriptor.GetBinDescriptor());

            return new FeatureDescriptor(binMat);
        }
    }



    class ImageFingerPrintVendor
    {
        private readonly ImgHashBase hashAlgo;
        private DescriptorExtractor extractor;
        private ORBDetector featureSearchAlgo;


        public ImageFingerPrintVendor(DescriptorExtractor extractor)
        {
            this.hashAlgo = new PHash();
            this.extractor = extractor;
            this.featureSearchAlgo = new ORBDetector(numberOfFeatures: 100, scoreType: ORBDetector.ScoreType.Fast);
        }


        public List<FingerPrint> GetImageFingerPrints(Mat image)
        {
            List<FingerPrint> fingerPrints = new List<FingerPrint>();

            var descriptors = CalculateDescriptors(image);

            for (int i = 0; i != descriptors.Count; i++)
            {
                var binDescriptor = extractor.TransformToBinSquare(descriptors[i]);
                var fingerPrint = ConvertDescriptorToFingerPrint(binDescriptor);
                fingerPrints.Add(fingerPrint);
            }

            return fingerPrints;
        }


        private List<FeatureDescriptor> CalculateDescriptors(Mat image)
        {
            Mat tmp = new Mat();
            featureSearchAlgo.DetectAndCompute(image, null, new VectorOfKeyPoint(), tmp, false);
            var descriptors = this.extractor.ExtractDescriptors(tmp);

            return descriptors;
        }


        private FingerPrint ConvertDescriptorToFingerPrint(FeatureDescriptor descriptor)
        {
            var hash = new Mat();
            this.hashAlgo.Compute(descriptor.Data, hash);
            var fingerPrint = new FingerPrint(BitConverter.ToInt64(hash.GetData(), 0));

            return fingerPrint;
        }
    }



    //100 дескрипторов и 70 персенте
    static class Program
    {
        [STAThread]
        public static void Main()
        {

            ImageFingerPrintVendor creator = new ImageFingerPrintVendor(new DescriptorExtractor(16, 16));
            Mat img1 = CvInvoke.Imread("orig.jpg");
            var fingerPrints1 = creator.GetImageFingerPrints(img1);

            Mat img2 = CvInvoke.Imread("box.png");
            var fingerPrints2 = creator.GetImageFingerPrints(img2);

            int res = 0;
            foreach (var fp in fingerPrints1)
            {
                foreach (var sp in fingerPrints2)
                {
                    var hd = fp.HammingDistanceTo(sp);
                    if ((((64 - hd) * 100) / 64) >= 70)
                        res++;
                }
            }

            res = (res * 100) / 100;

            Console.WriteLine(res);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm frameM = new MainForm();


            Application.Run(frameM);
            
        }
    }


}
