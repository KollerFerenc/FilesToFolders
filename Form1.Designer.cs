namespace FilesToFolders
{
    partial class Form1
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
            this.txtTrimText = new System.Windows.Forms.TextBox();
            this.lblTrimText = new System.Windows.Forms.Label();
            this.rbtnTrimRight = new System.Windows.Forms.RadioButton();
            this.rbtnTrimLeft = new System.Windows.Forms.RadioButton();
            this.gbxTrim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(12, 141);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(325, 141);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(12, 17);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 2;
            this.lblFolder.Text = "Folder:";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Location = new System.Drawing.Point(325, 13);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.Text = "Open folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // txtFolderLocation
            // 
            this.txtFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderLocation.Location = new System.Drawing.Point(53, 15);
            this.txtFolderLocation.Name = "txtFolderLocation";
            this.txtFolderLocation.Size = new System.Drawing.Size(266, 20);
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
            this.gbxTrim.Location = new System.Drawing.Point(15, 41);
            this.gbxTrim.Name = "gbxTrim";
            this.gbxTrim.Size = new System.Drawing.Size(385, 94);
            this.gbxTrim.TabIndex = 5;
            this.gbxTrim.TabStop = false;
            this.gbxTrim.Text = "Trim";
            // 
            // txtTrimText
            // 
            this.txtTrimText.Location = new System.Drawing.Point(71, 19);
            this.txtTrimText.Name = "txtTrimText";
            this.txtTrimText.Size = new System.Drawing.Size(100, 20);
            this.txtTrimText.TabIndex = 0;
            // 
            // lblTrimText
            // 
            this.lblTrimText.AutoSize = true;
            this.lblTrimText.Location = new System.Drawing.Point(6, 22);
            this.lblTrimText.Name = "lblTrimText";
            this.lblTrimText.Size = new System.Drawing.Size(59, 13);
            this.lblTrimText.TabIndex = 1;
            this.lblTrimText.Text = "Text to trim";
            // 
            // rbtnTrimRight
            // 
            this.rbtnTrimRight.AutoSize = true;
            this.rbtnTrimRight.Checked = true;
            this.rbtnTrimRight.Location = new System.Drawing.Point(6, 45);
            this.rbtnTrimRight.Name = "rbtnTrimRight";
            this.rbtnTrimRight.Size = new System.Drawing.Size(68, 17);
            this.rbtnTrimRight.TabIndex = 2;
            this.rbtnTrimRight.TabStop = true;
            this.rbtnTrimRight.Text = "Trim right";
            this.rbtnTrimRight.UseVisualStyleBackColor = true;
            // 
            // rbtnTrimLeft
            // 
            this.rbtnTrimLeft.AutoSize = true;
            this.rbtnTrimLeft.Enabled = false;
            this.rbtnTrimLeft.Location = new System.Drawing.Point(6, 68);
            this.rbtnTrimLeft.Name = "rbtnTrimLeft";
            this.rbtnTrimLeft.Size = new System.Drawing.Size(62, 17);
            this.rbtnTrimLeft.TabIndex = 3;
            this.rbtnTrimLeft.Text = "Trim left";
            this.rbtnTrimLeft.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 176);
            this.Controls.Add(this.gbxTrim);
            this.Controls.Add(this.txtFolderLocation);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(428, 215);
            this.Name = "Form1";
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

