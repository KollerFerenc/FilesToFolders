namespace FilesToFolders
{
    partial class FrmMain
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txtFolderLocation = new System.Windows.Forms.TextBox();
            this.gbxTrim = new System.Windows.Forms.GroupBox();
            this.rbtnTrimLeft = new System.Windows.Forms.RadioButton();
            this.rbtnTrimRight = new System.Windows.Forms.RadioButton();
            this.lblTrimText = new System.Windows.Forms.Label();
            this.txtTrimText = new System.Windows.Forms.TextBox();
            this.gbxTrim.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(14, 163);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(379, 163);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 27);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(14, 20);
            this.lblFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(43, 15);
            this.lblFolder.TabIndex = 2;
            this.lblFolder.Text = "Folder:";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Location = new System.Drawing.Point(379, 15);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(88, 27);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.Text = "Open folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // txtFolderLocation
            // 
            this.txtFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderLocation.Location = new System.Drawing.Point(62, 17);
            this.txtFolderLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFolderLocation.Name = "txtFolderLocation";
            this.txtFolderLocation.Size = new System.Drawing.Size(310, 23);
            this.txtFolderLocation.TabIndex = 4;
            // 
            // gbxTrim
            // 
            this.gbxTrim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTrim.Controls.Add(this.rbtnTrimLeft);
            this.gbxTrim.Controls.Add(this.rbtnTrimRight);
            this.gbxTrim.Controls.Add(this.lblTrimText);
            this.gbxTrim.Controls.Add(this.txtTrimText);
            this.gbxTrim.Location = new System.Drawing.Point(18, 47);
            this.gbxTrim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxTrim.Name = "gbxTrim";
            this.gbxTrim.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxTrim.Size = new System.Drawing.Size(449, 108);
            this.gbxTrim.TabIndex = 5;
            this.gbxTrim.TabStop = false;
            this.gbxTrim.Text = "Trim";
            // 
            // rbtnTrimLeft
            // 
            this.rbtnTrimLeft.AutoSize = true;
            this.rbtnTrimLeft.Enabled = false;
            this.rbtnTrimLeft.Location = new System.Drawing.Point(7, 78);
            this.rbtnTrimLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnTrimLeft.Name = "rbtnTrimLeft";
            this.rbtnTrimLeft.Size = new System.Drawing.Size(68, 19);
            this.rbtnTrimLeft.TabIndex = 3;
            this.rbtnTrimLeft.Text = "Trim left";
            this.rbtnTrimLeft.UseVisualStyleBackColor = true;
            // 
            // rbtnTrimRight
            // 
            this.rbtnTrimRight.AutoSize = true;
            this.rbtnTrimRight.Checked = true;
            this.rbtnTrimRight.Location = new System.Drawing.Point(7, 52);
            this.rbtnTrimRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnTrimRight.Name = "rbtnTrimRight";
            this.rbtnTrimRight.Size = new System.Drawing.Size(76, 19);
            this.rbtnTrimRight.TabIndex = 2;
            this.rbtnTrimRight.TabStop = true;
            this.rbtnTrimRight.Text = "Trim right";
            this.rbtnTrimRight.UseVisualStyleBackColor = true;
            // 
            // lblTrimText
            // 
            this.lblTrimText.AutoSize = true;
            this.lblTrimText.Location = new System.Drawing.Point(7, 25);
            this.lblTrimText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrimText.Name = "lblTrimText";
            this.lblTrimText.Size = new System.Drawing.Size(67, 15);
            this.lblTrimText.TabIndex = 1;
            this.lblTrimText.Text = "Text to trim";
            // 
            // txtTrimText
            // 
            this.txtTrimText.Location = new System.Drawing.Point(83, 22);
            this.txtTrimText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTrimText.Name = "txtTrimText";
            this.txtTrimText.Size = new System.Drawing.Size(116, 23);
            this.txtTrimText.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 203);
            this.Controls.Add(this.gbxTrim);
            this.Controls.Add(this.txtFolderLocation);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(497, 242);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Files to Folders";
            this.gbxTrim.ResumeLayout(false);
            this.gbxTrim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox txtFolderLocation;
        private System.Windows.Forms.GroupBox gbxTrim;
        private System.Windows.Forms.RadioButton rbtnTrimLeft;
        private System.Windows.Forms.RadioButton rbtnTrimRight;
        private System.Windows.Forms.Label lblTrimText;
        private System.Windows.Forms.TextBox txtTrimText;
    }
}

