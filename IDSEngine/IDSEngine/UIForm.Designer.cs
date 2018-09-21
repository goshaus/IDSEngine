namespace DuplicateDetector
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainLabel = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftImageButton = new System.Windows.Forms.Button();
            this.rightImageButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.dataTree = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileClauseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataClauseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addZipClauseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addImagesClauseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveZipClauseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clusterClauseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clusteringClauseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.topPanel.Controls.Add(this.mainLabel);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(928, 38);
            this.topPanel.TabIndex = 1;
            // 
            // mainLabel
            // 
            this.mainLabel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.mainLabel.FlatAppearance.BorderSize = 0;
            this.mainLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.mainLabel.Location = new System.Drawing.Point(351, 3);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(205, 29);
            this.mainLabel.TabIndex = 3;
            this.mainLabel.Text = "IDS Engine";
            this.mainLabel.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.exitButton.Location = new System.Drawing.Point(894, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 29);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.progressBar);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.leftImageButton);
            this.mainPanel.Controls.Add(this.rightImageButton);
            this.mainPanel.Controls.Add(this.pictureBox);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainPanel.Location = new System.Drawing.Point(-2, 58);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(930, 456);
            this.mainPanel.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-1, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(705, 7);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(705, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 447);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 2);
            this.panel1.TabIndex = 5;
            // 
            // leftImageButton
            // 
            this.leftImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.leftImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.leftImageButton.FlatAppearance.BorderSize = 0;
            this.leftImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftImageButton.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.leftImageButton.Location = new System.Drawing.Point(0, 3);
            this.leftImageButton.Name = "leftImageButton";
            this.leftImageButton.Size = new System.Drawing.Size(31, 449);
            this.leftImageButton.TabIndex = 4;
            this.leftImageButton.Text = "◄";
            this.leftImageButton.UseVisualStyleBackColor = false;
            this.leftImageButton.Click += new System.EventHandler(this.LeftImageButtonClick);
            // 
            // rightImageButton
            // 
            this.rightImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.rightImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.rightImageButton.FlatAppearance.BorderSize = 0;
            this.rightImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightImageButton.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rightImageButton.Location = new System.Drawing.Point(678, 3);
            this.rightImageButton.Name = "rightImageButton";
            this.rightImageButton.Size = new System.Drawing.Size(28, 449);
            this.rightImageButton.TabIndex = 2;
            this.rightImageButton.Text = "►";
            this.rightImageButton.UseVisualStyleBackColor = false;
            this.rightImageButton.Click += new System.EventHandler(this.RightImageButtonClick);
            // 
            // pictureBox
            // 
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(21, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(651, 415);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.rightPanel.Controls.Add(this.dataTree);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(708, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(220, 454);
            this.rightPanel.TabIndex = 0;
            // 
            // dataTree
            // 
            this.dataTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.dataTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTree.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.dataTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.dataTree.Location = new System.Drawing.Point(12, 19);
            this.dataTree.Name = "dataTree";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            this.dataTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.dataTree.Size = new System.Drawing.Size(194, 400);
            this.dataTree.TabIndex = 0;
            this.dataTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DataTreeNodeDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.panel3.Controls.Add(this.menuStrip);
            this.panel3.Location = new System.Drawing.Point(-2, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 31);
            this.panel3.TabIndex = 3;
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip.BackgroundImage")));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileClauseMenu,
            this.clusterClauseMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(930, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileClauseMenu
            // 
            this.fileClauseMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileClauseMenu.BackgroundImage")));
            this.fileClauseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDataClauseMenu,
            this.saveZipClauseMenu});
            this.fileClauseMenu.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileClauseMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.fileClauseMenu.Name = "fileClauseMenu";
            this.fileClauseMenu.Size = new System.Drawing.Size(44, 22);
            this.fileClauseMenu.Text = "File";
            // 
            // addDataClauseMenu
            // 
            this.addDataClauseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addZipClauseMenu,
            this.addImagesClauseMenu});
            this.addDataClauseMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.addDataClauseMenu.Name = "addDataClauseMenu";
            this.addDataClauseMenu.Size = new System.Drawing.Size(152, 22);
            this.addDataClauseMenu.Text = "Add";
            // 
            // addZipClauseMenu
            // 
            this.addZipClauseMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.addZipClauseMenu.Name = "addZipClauseMenu";
            this.addZipClauseMenu.Size = new System.Drawing.Size(153, 22);
            this.addZipClauseMenu.Text = "Add .zip";
            this.addZipClauseMenu.Click += new System.EventHandler(this.AddZipClauseMenuClick);
            // 
            // addImagesClauseMenu
            // 
            this.addImagesClauseMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.addImagesClauseMenu.Name = "addImagesClauseMenu";
            this.addImagesClauseMenu.Size = new System.Drawing.Size(153, 22);
            this.addImagesClauseMenu.Text = "Add Images";
            this.addImagesClauseMenu.Click += new System.EventHandler(this.AddImagesClauseMenuClick);
            // 
            // saveZipClauseMenu
            // 
            this.saveZipClauseMenu.Name = "saveZipClauseMenu";
            this.saveZipClauseMenu.Size = new System.Drawing.Size(152, 22);
            this.saveZipClauseMenu.Text = "Save as .zip";
            this.saveZipClauseMenu.Click += new System.EventHandler(this.SaveZipClauseMenuClick);
            // 
            // clusterClauseMenu
            // 
            this.clusterClauseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clusteringClauseMenu});
            this.clusterClauseMenu.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.clusterClauseMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.clusterClauseMenu.Name = "clusterClauseMenu";
            this.clusterClauseMenu.Size = new System.Drawing.Size(67, 22);
            this.clusterClauseMenu.Text = "Cluster";
            // 
            // clusteringClauseMenu
            // 
            this.clusteringClauseMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.clusteringClauseMenu.Name = "clusteringClauseMenu";
            this.clusteringClauseMenu.Size = new System.Drawing.Size(206, 22);
            this.clusteringClauseMenu.Text = "Duplicate clustering";
            this.clusteringClauseMenu.Click += new System.EventHandler(this.ClusteringClauseMenuClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI";
            this.topPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mainLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.TreeView dataTree;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileClauseMenu;
        private System.Windows.Forms.ToolStripMenuItem addDataClauseMenu;
        private System.Windows.Forms.ToolStripMenuItem addZipClauseMenu;
        private System.Windows.Forms.ToolStripMenuItem addImagesClauseMenu;
        private System.Windows.Forms.ToolStripMenuItem saveZipClauseMenu;
        private System.Windows.Forms.ToolStripMenuItem clusterClauseMenu;
        private System.Windows.Forms.ToolStripMenuItem clusteringClauseMenu;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button leftImageButton;
        private System.Windows.Forms.Button rightImageButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}