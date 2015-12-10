namespace CopyFileNamesAssistant
{
    partial class FormCopyFileNames
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCopyFileNames));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCopy = new System.Windows.Forms.TabPage();
            this.btnCopyFileNameOnly = new System.Windows.Forms.Button();
            this.btnCopyFallName = new System.Windows.Forms.Button();
            this.txbFallName = new System.Windows.Forms.TextBox();
            this.tabPageFolder = new System.Windows.Forms.TabPage();
            this.txbPrefix = new System.Windows.Forms.TextBox();
            this.btnCreatFolders = new System.Windows.Forms.Button();
            this.tabPageCatelog = new System.Windows.Forms.TabPage();
            this.libFiles = new System.Windows.Forms.ListBox();
            this.nudScales = new System.Windows.Forms.NumericUpDown();
            this.labTotal = new System.Windows.Forms.Label();
            this.btnCatelog = new System.Windows.Forms.Button();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageWeChant = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageCopy.SuspendLayout();
            this.tabPageFolder.SuspendLayout();
            this.tabPageCatelog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScales)).BeginInit();
            this.tabPageHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageWeChant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMsg,
            this.toolStripStatusLabelNumber});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(412, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMsg
            // 
            this.toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            this.toolStripStatusLabelMsg.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabelMsg.Text = "总文件数目:";
            // 
            // toolStripStatusLabelNumber
            // 
            this.toolStripStatusLabelNumber.Name = "toolStripStatusLabelNumber";
            this.toolStripStatusLabelNumber.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabelNumber.Text = "0";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageCopy);
            this.tabControl.Controls.Add(this.tabPageFolder);
            this.tabControl.Controls.Add(this.tabPageCatelog);
            this.tabControl.Controls.Add(this.tabPageHelp);
            this.tabControl.Controls.Add(this.tabPageWeChant);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(412, 426);
            this.tabControl.TabIndex = 1;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabPageCopy
            // 
            this.tabPageCopy.Controls.Add(this.btnCopyFileNameOnly);
            this.tabPageCopy.Controls.Add(this.btnCopyFallName);
            this.tabPageCopy.Controls.Add(this.txbFallName);
            this.tabPageCopy.Location = new System.Drawing.Point(4, 22);
            this.tabPageCopy.Name = "tabPageCopy";
            this.tabPageCopy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCopy.Size = new System.Drawing.Size(404, 400);
            this.tabPageCopy.TabIndex = 0;
            this.tabPageCopy.Text = "复制";
            this.tabPageCopy.UseVisualStyleBackColor = true;
            // 
            // btnCopyFileNameOnly
            // 
            this.btnCopyFileNameOnly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyFileNameOnly.Location = new System.Drawing.Point(8, 35);
            this.btnCopyFileNameOnly.Name = "btnCopyFileNameOnly";
            this.btnCopyFileNameOnly.Size = new System.Drawing.Size(388, 23);
            this.btnCopyFileNameOnly.TabIndex = 1;
            this.btnCopyFileNameOnly.Text = "复制主名(不带后缀)CopyFile&NameOnly";
            this.btnCopyFileNameOnly.UseVisualStyleBackColor = true;
            this.btnCopyFileNameOnly.Click += new System.EventHandler(this.btnCopyFileNameOnly_Click);
            // 
            // btnCopyFallName
            // 
            this.btnCopyFallName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyFallName.Location = new System.Drawing.Point(8, 6);
            this.btnCopyFallName.Name = "btnCopyFallName";
            this.btnCopyFallName.Size = new System.Drawing.Size(388, 23);
            this.btnCopyFallName.TabIndex = 1;
            this.btnCopyFallName.Text = "复制全名(带后缀)&CopyFallName";
            this.btnCopyFallName.UseVisualStyleBackColor = true;
            this.btnCopyFallName.Click += new System.EventHandler(this.btnCopyFallName_Click);
            // 
            // txbFallName
            // 
            this.txbFallName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFallName.Location = new System.Drawing.Point(3, 64);
            this.txbFallName.Multiline = true;
            this.txbFallName.Name = "txbFallName";
            this.txbFallName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbFallName.Size = new System.Drawing.Size(398, 330);
            this.txbFallName.TabIndex = 0;
            this.txbFallName.WordWrap = false;
            // 
            // tabPageFolder
            // 
            this.tabPageFolder.Controls.Add(this.txbPrefix);
            this.tabPageFolder.Controls.Add(this.btnCreatFolders);
            this.tabPageFolder.Location = new System.Drawing.Point(4, 22);
            this.tabPageFolder.Name = "tabPageFolder";
            this.tabPageFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFolder.Size = new System.Drawing.Size(404, 400);
            this.tabPageFolder.TabIndex = 1;
            this.tabPageFolder.Text = "创建目录";
            this.tabPageFolder.UseVisualStyleBackColor = true;
            // 
            // txbPrefix
            // 
            this.txbPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrefix.Location = new System.Drawing.Point(3, 32);
            this.txbPrefix.Multiline = true;
            this.txbPrefix.Name = "txbPrefix";
            this.txbPrefix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbPrefix.Size = new System.Drawing.Size(398, 365);
            this.txbPrefix.TabIndex = 1;
            this.txbPrefix.WordWrap = false;
            // 
            // btnCreatFolders
            // 
            this.btnCreatFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreatFolders.Location = new System.Drawing.Point(6, 6);
            this.btnCreatFolders.Name = "btnCreatFolders";
            this.btnCreatFolders.Size = new System.Drawing.Size(392, 23);
            this.btnCreatFolders.TabIndex = 0;
            this.btnCreatFolders.Text = "同路径下新建文件夹Creat&FolderInCurrentPath";
            this.btnCreatFolders.UseVisualStyleBackColor = true;
            this.btnCreatFolders.Click += new System.EventHandler(this.btnCreatFolders_Click);
            // 
            // tabPageCatelog
            // 
            this.tabPageCatelog.Controls.Add(this.libFiles);
            this.tabPageCatelog.Controls.Add(this.nudScales);
            this.tabPageCatelog.Controls.Add(this.labTotal);
            this.tabPageCatelog.Controls.Add(this.btnCatelog);
            this.tabPageCatelog.Location = new System.Drawing.Point(4, 22);
            this.tabPageCatelog.Name = "tabPageCatelog";
            this.tabPageCatelog.Size = new System.Drawing.Size(404, 400);
            this.tabPageCatelog.TabIndex = 2;
            this.tabPageCatelog.Text = "归档";
            this.tabPageCatelog.UseVisualStyleBackColor = true;
            // 
            // libFiles
            // 
            this.libFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libFiles.FormattingEnabled = true;
            this.libFiles.ItemHeight = 12;
            this.libFiles.Location = new System.Drawing.Point(3, 3);
            this.libFiles.Name = "libFiles";
            this.libFiles.Size = new System.Drawing.Size(398, 328);
            this.libFiles.TabIndex = 4;
            // 
            // nudScales
            // 
            this.nudScales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudScales.Location = new System.Drawing.Point(8, 374);
            this.nudScales.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudScales.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScales.Name = "nudScales";
            this.nudScales.Size = new System.Drawing.Size(192, 21);
            this.nudScales.TabIndex = 3;
            this.nudScales.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labTotal
            // 
            this.labTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTotal.AutoSize = true;
            this.labTotal.ForeColor = System.Drawing.Color.Red;
            this.labTotal.Location = new System.Drawing.Point(6, 343);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(227, 12);
            this.labTotal.TabIndex = 2;
            this.labTotal.Text = "共计0个文件,每几个文件归档一个文件夹?";
            // 
            // btnCatelog
            // 
            this.btnCatelog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatelog.Location = new System.Drawing.Point(206, 374);
            this.btnCatelog.Name = "btnCatelog";
            this.btnCatelog.Size = new System.Drawing.Size(190, 23);
            this.btnCatelog.TabIndex = 0;
            this.btnCatelog.Text = "按照上述条件归档Cata&log";
            this.btnCatelog.UseVisualStyleBackColor = true;
            this.btnCatelog.Click += new System.EventHandler(this.btnCatelog_Click);
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.pictureBox1);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 22);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Size = new System.Drawing.Size(404, 400);
            this.tabPageHelp.TabIndex = 3;
            this.tabPageHelp.Text = "支付宝";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPageWeChant
            // 
            this.tabPageWeChant.Controls.Add(this.pictureBox2);
            this.tabPageWeChant.Location = new System.Drawing.Point(4, 22);
            this.tabPageWeChant.Name = "tabPageWeChant";
            this.tabPageWeChant.Size = new System.Drawing.Size(404, 400);
            this.tabPageWeChant.TabIndex = 4;
            this.tabPageWeChant.Text = "微信";
            this.tabPageWeChant.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // FormCopyFileNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 451);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCopyFileNames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "opyFileNamesAssistant";
            this.TopMost = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageCopy.ResumeLayout(false);
            this.tabPageCopy.PerformLayout();
            this.tabPageFolder.ResumeLayout(false);
            this.tabPageFolder.PerformLayout();
            this.tabPageCatelog.ResumeLayout(false);
            this.tabPageCatelog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScales)).EndInit();
            this.tabPageHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageWeChant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCopy;
        private System.Windows.Forms.TabPage tabPageFolder;
        private System.Windows.Forms.TabPage tabPageCatelog;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMsg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNumber;
        private System.Windows.Forms.Button btnCopyFileNameOnly;
        private System.Windows.Forms.Button btnCopyFallName;
        private System.Windows.Forms.TextBox txbFallName;
        private System.Windows.Forms.TextBox txbPrefix;
        private System.Windows.Forms.Button btnCreatFolders;
        private System.Windows.Forms.Button btnCatelog;
        private System.Windows.Forms.NumericUpDown nudScales;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.ListBox libFiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageWeChant;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

