using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateDetector
{

    public interface IMainForm
    {
        string[] OpenFileNames { get; }
        string SaveFolderName { get; }
        Image CurrentImage { get; set; }
        string PickedTreeNodePath { get; }
        event EventHandler OpenZip;
        event EventHandler OpenImages;
        event EventHandler SaveAsArchive;
        event EventHandler Exit;
        event EventHandler LeftImage;
        event EventHandler RightImage;
        event EventHandler PickedTreeNode;
        event EventHandler Clustering;
    }


    public partial class MainForm : Form, IMainForm
    {
        public string[] OpenFileNames { get; private set; }
        public string SaveFolderName { get; private set; }
        private string archiveConstraint = "Archives (*.zip)|*.zip";
        private string imageConstraint = "Images (*.png)|*.png";
        public Image CurrentImage { get; set; }
        public string PickedTreeNodePath { get; private set; }

        public event EventHandler OpenZip;
        public event EventHandler OpenImages;
        public event EventHandler SaveAsArchive;
        public event EventHandler Exit;
        public event EventHandler LeftImage;
        public event EventHandler RightImage;
        public event EventHandler PickedTreeNode;
        public event EventHandler Clustering;


        public MainForm()
        {
            InitializeComponent();
        }


        public void SetPictureBoxImage()
        {
            this.pictureBox.Image = CurrentImage;
        }


        public void DataTreeCollection(TreeNode[] collection)
        {
            this.dataTree.Nodes.AddRange(collection);     
        }


        private void ExitButtonClick(object sender, EventArgs e)
        {
            Exit?.Invoke(sender, e);
            Application.Exit();
        }


        private void AddZipClauseMenuClick(object sender, EventArgs e)
        {
            ShowFileDialog(this.archiveConstraint);
            OpenZip?.Invoke(sender, e);
        }


        private void AddImagesClauseMenuClick(object sender, EventArgs e)
        {
            ShowFileDialog(this.imageConstraint);
            OpenImages?.Invoke(sender, e);
        }


        private void DataTreeNodeDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            var path = node.FullPath;
            PickedTreeNode?.Invoke(sender, e);
        }


        private void ClusteringClauseMenuClick(object sender, EventArgs e)
        {
            Clustering?.Invoke(sender, e);
        }


        private void SaveZipClauseMenuClick(object sender, EventArgs e)
        {
            ShowSaveDialog();
            SaveAsArchive?.Invoke(sender, e);
        }


        private void RightImageButtonClick(object sender, EventArgs e)
        {
            RightImage?.Invoke(sender, e);
            SetPictureBoxImage();
        }


        private void LeftImageButtonClick(object sender, EventArgs e)
        {
            LeftImage?.Invoke(sender, e);
            SetPictureBoxImage();
        }


        private void ShowFileDialog(string constraints)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = constraints
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.OpenFileNames = dialog.FileNames;
            }
        }


        private void ShowSaveDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.SaveFolderName = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
