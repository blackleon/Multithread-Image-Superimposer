namespace ImageSuperimposer
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
            this.imageFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.transparentFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_imageFolder = new System.Windows.Forms.Button();
            this.btn_transparentFolder = new System.Windows.Forms.Button();
            this.btn_outputFolder = new System.Windows.Forms.Button();
            this.outputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_imageFolder = new System.Windows.Forms.TextBox();
            this.txt_transparentFolder = new System.Windows.Forms.TextBox();
            this.txt_outputFolder = new System.Windows.Forms.TextBox();
            this.lbl_imageFolder = new System.Windows.Forms.Label();
            this.lbl_transparentFolder = new System.Windows.Forms.Label();
            this.lbl_outputFolder = new System.Windows.Forms.Label();
            this.trbr_opacity = new System.Windows.Forms.TrackBar();
            this.txt_opacity = new System.Windows.Forms.TextBox();
            this.lbl_opacity = new System.Windows.Forms.Label();
            this.fontSelector = new System.Windows.Forms.FontDialog();
            this.txt_fontSelector = new System.Windows.Forms.TextBox();
            this.btn_fontSelector = new System.Windows.Forms.Button();
            this.prbar = new System.Windows.Forms.ProgressBar();
            this.btn_generate = new System.Windows.Forms.Button();
            this.txt_openFile = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.txt_lastIndex = new System.Windows.Forms.TextBox();
            this.lbl_lastIndex = new System.Windows.Forms.Label();
            this.lbl_Font = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.cbb_outextension = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_threads = new System.Windows.Forms.TextBox();
            this.lbl_threads = new System.Windows.Forms.Label();
            this.lbl_bitmapPool = new System.Windows.Forms.Label();
            this.txt_bitmapPool = new System.Windows.Forms.TextBox();
            this.pnl_color = new System.Windows.Forms.Panel();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.btn_colorPick = new System.Windows.Forms.Button();
            this.bWorker = new System.ComponentModel.BackgroundWorker();
            this.btn_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbr_opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_imageFolder
            // 
            this.btn_imageFolder.Location = new System.Drawing.Point(8, 16);
            this.btn_imageFolder.Name = "btn_imageFolder";
            this.btn_imageFolder.Size = new System.Drawing.Size(89, 23);
            this.btn_imageFolder.TabIndex = 0;
            this.btn_imageFolder.Text = "Select";
            this.btn_imageFolder.UseVisualStyleBackColor = true;
            this.btn_imageFolder.Click += new System.EventHandler(this.btn_imageFolder_Click);
            // 
            // btn_transparentFolder
            // 
            this.btn_transparentFolder.Location = new System.Drawing.Point(8, 50);
            this.btn_transparentFolder.Name = "btn_transparentFolder";
            this.btn_transparentFolder.Size = new System.Drawing.Size(89, 23);
            this.btn_transparentFolder.TabIndex = 1;
            this.btn_transparentFolder.Text = "Select";
            this.btn_transparentFolder.UseVisualStyleBackColor = true;
            this.btn_transparentFolder.Click += new System.EventHandler(this.btn_transparentFolder_Click);
            // 
            // btn_outputFolder
            // 
            this.btn_outputFolder.Location = new System.Drawing.Point(8, 191);
            this.btn_outputFolder.Name = "btn_outputFolder";
            this.btn_outputFolder.Size = new System.Drawing.Size(89, 20);
            this.btn_outputFolder.TabIndex = 6;
            this.btn_outputFolder.Text = "Select";
            this.btn_outputFolder.UseVisualStyleBackColor = true;
            this.btn_outputFolder.Click += new System.EventHandler(this.btn_outputFolder_Click);
            // 
            // txt_imageFolder
            // 
            this.txt_imageFolder.Enabled = false;
            this.txt_imageFolder.Location = new System.Drawing.Point(103, 16);
            this.txt_imageFolder.Name = "txt_imageFolder";
            this.txt_imageFolder.Size = new System.Drawing.Size(498, 20);
            this.txt_imageFolder.TabIndex = 1;
            // 
            // txt_transparentFolder
            // 
            this.txt_transparentFolder.Enabled = false;
            this.txt_transparentFolder.Location = new System.Drawing.Point(103, 50);
            this.txt_transparentFolder.Name = "txt_transparentFolder";
            this.txt_transparentFolder.Size = new System.Drawing.Size(498, 20);
            this.txt_transparentFolder.TabIndex = 3;
            // 
            // txt_outputFolder
            // 
            this.txt_outputFolder.Enabled = false;
            this.txt_outputFolder.Location = new System.Drawing.Point(103, 191);
            this.txt_outputFolder.Name = "txt_outputFolder";
            this.txt_outputFolder.Size = new System.Drawing.Size(498, 20);
            this.txt_outputFolder.TabIndex = 5;
            // 
            // lbl_imageFolder
            // 
            this.lbl_imageFolder.AutoSize = true;
            this.lbl_imageFolder.Location = new System.Drawing.Point(106, 4);
            this.lbl_imageFolder.Name = "lbl_imageFolder";
            this.lbl_imageFolder.Size = new System.Drawing.Size(100, 13);
            this.lbl_imageFolder.TabIndex = 6;
            this.lbl_imageFolder.Text = "Base Images Folder";
            // 
            // lbl_transparentFolder
            // 
            this.lbl_transparentFolder.AutoSize = true;
            this.lbl_transparentFolder.Location = new System.Drawing.Point(106, 38);
            this.lbl_transparentFolder.Name = "lbl_transparentFolder";
            this.lbl_transparentFolder.Size = new System.Drawing.Size(133, 13);
            this.lbl_transparentFolder.TabIndex = 7;
            this.lbl_transparentFolder.Text = "Transparent Images Folder";
            // 
            // lbl_outputFolder
            // 
            this.lbl_outputFolder.AutoSize = true;
            this.lbl_outputFolder.Location = new System.Drawing.Point(106, 179);
            this.lbl_outputFolder.Name = "lbl_outputFolder";
            this.lbl_outputFolder.Size = new System.Drawing.Size(71, 13);
            this.lbl_outputFolder.TabIndex = 8;
            this.lbl_outputFolder.Text = "Output Folder";
            // 
            // trbr_opacity
            // 
            this.trbr_opacity.Location = new System.Drawing.Point(103, 83);
            this.trbr_opacity.Maximum = 100;
            this.trbr_opacity.Name = "trbr_opacity";
            this.trbr_opacity.Size = new System.Drawing.Size(498, 45);
            this.trbr_opacity.TabIndex = 2;
            this.trbr_opacity.Value = 100;
            this.trbr_opacity.Scroll += new System.EventHandler(this.trbr_opacity_Scroll);
            // 
            // txt_opacity
            // 
            this.txt_opacity.Enabled = false;
            this.txt_opacity.Location = new System.Drawing.Point(8, 83);
            this.txt_opacity.Name = "txt_opacity";
            this.txt_opacity.Size = new System.Drawing.Size(89, 20);
            this.txt_opacity.TabIndex = 10;
            this.txt_opacity.Text = "100";
            this.txt_opacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_opacity
            // 
            this.lbl_opacity.AutoSize = true;
            this.lbl_opacity.Location = new System.Drawing.Point(103, 73);
            this.lbl_opacity.Name = "lbl_opacity";
            this.lbl_opacity.Size = new System.Drawing.Size(43, 13);
            this.lbl_opacity.TabIndex = 11;
            this.lbl_opacity.Text = "Opacity";
            // 
            // txt_fontSelector
            // 
            this.txt_fontSelector.Enabled = false;
            this.txt_fontSelector.Location = new System.Drawing.Point(103, 155);
            this.txt_fontSelector.Name = "txt_fontSelector";
            this.txt_fontSelector.Size = new System.Drawing.Size(324, 20);
            this.txt_fontSelector.TabIndex = 13;
            // 
            // btn_fontSelector
            // 
            this.btn_fontSelector.Location = new System.Drawing.Point(8, 155);
            this.btn_fontSelector.Name = "btn_fontSelector";
            this.btn_fontSelector.Size = new System.Drawing.Size(89, 21);
            this.btn_fontSelector.TabIndex = 4;
            this.btn_fontSelector.Text = "Select";
            this.btn_fontSelector.UseVisualStyleBackColor = true;
            this.btn_fontSelector.Click += new System.EventHandler(this.btn_fontSelector_Click);
            // 
            // prbar
            // 
            this.prbar.Location = new System.Drawing.Point(8, 291);
            this.prbar.Name = "prbar";
            this.prbar.Size = new System.Drawing.Size(594, 26);
            this.prbar.TabIndex = 15;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(302, 222);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(300, 59);
            this.btn_generate.TabIndex = 11;
            this.btn_generate.Text = "Generate Images";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txt_openFile
            // 
            this.txt_openFile.Enabled = false;
            this.txt_openFile.Location = new System.Drawing.Point(103, 121);
            this.txt_openFile.Name = "txt_openFile";
            this.txt_openFile.Size = new System.Drawing.Size(498, 20);
            this.txt_openFile.TabIndex = 5;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(8, 121);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(89, 20);
            this.btn_openFile.TabIndex = 3;
            this.btn_openFile.Text = "Select";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // txt_lastIndex
            // 
            this.txt_lastIndex.Location = new System.Drawing.Point(103, 225);
            this.txt_lastIndex.Name = "txt_lastIndex";
            this.txt_lastIndex.Size = new System.Drawing.Size(89, 20);
            this.txt_lastIndex.TabIndex = 8;
            this.txt_lastIndex.Text = "0";
            // 
            // lbl_lastIndex
            // 
            this.lbl_lastIndex.AutoSize = true;
            this.lbl_lastIndex.Location = new System.Drawing.Point(107, 213);
            this.lbl_lastIndex.Name = "lbl_lastIndex";
            this.lbl_lastIndex.Size = new System.Drawing.Size(56, 13);
            this.lbl_lastIndex.TabIndex = 26;
            this.lbl_lastIndex.Text = "Last Index";
            // 
            // lbl_Font
            // 
            this.lbl_Font.AutoSize = true;
            this.lbl_Font.Location = new System.Drawing.Point(106, 143);
            this.lbl_Font.Name = "lbl_Font";
            this.lbl_Font.Size = new System.Drawing.Size(28, 13);
            this.lbl_Font.TabIndex = 27;
            this.lbl_Font.Text = "Font";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Words File";
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Location = new System.Drawing.Point(12, 298);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(33, 13);
            this.lbl_progress.TabIndex = 29;
            this.lbl_progress.Text = "blank";
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Location = new System.Drawing.Point(12, 212);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(54, 13);
            this.lbl_filename.TabIndex = 31;
            this.lbl_filename.Text = "File Name";
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(8, 224);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(89, 20);
            this.txt_filename.TabIndex = 7;
            this.txt_filename.Text = "output";
            // 
            // cbb_outextension
            // 
            this.cbb_outextension.FormattingEnabled = true;
            this.cbb_outextension.Location = new System.Drawing.Point(198, 259);
            this.cbb_outextension.Name = "cbb_outextension";
            this.cbb_outextension.Size = new System.Drawing.Size(98, 21);
            this.cbb_outextension.TabIndex = 11;
            this.cbb_outextension.Text = "Dropdown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Extension";
            // 
            // txt_threads
            // 
            this.txt_threads.Location = new System.Drawing.Point(8, 260);
            this.txt_threads.Name = "txt_threads";
            this.txt_threads.Size = new System.Drawing.Size(89, 20);
            this.txt_threads.TabIndex = 9;
            this.txt_threads.Text = "1";
            // 
            // lbl_threads
            // 
            this.lbl_threads.AutoSize = true;
            this.lbl_threads.Location = new System.Drawing.Point(12, 248);
            this.lbl_threads.Name = "lbl_threads";
            this.lbl_threads.Size = new System.Drawing.Size(46, 13);
            this.lbl_threads.TabIndex = 35;
            this.lbl_threads.Text = "Threads";
            // 
            // lbl_bitmapPool
            // 
            this.lbl_bitmapPool.AutoSize = true;
            this.lbl_bitmapPool.Location = new System.Drawing.Point(107, 248);
            this.lbl_bitmapPool.Name = "lbl_bitmapPool";
            this.lbl_bitmapPool.Size = new System.Drawing.Size(51, 13);
            this.lbl_bitmapPool.TabIndex = 37;
            this.lbl_bitmapPool.Text = "Pool Size";
            // 
            // txt_bitmapPool
            // 
            this.txt_bitmapPool.Location = new System.Drawing.Point(103, 260);
            this.txt_bitmapPool.Name = "txt_bitmapPool";
            this.txt_bitmapPool.Size = new System.Drawing.Size(89, 20);
            this.txt_bitmapPool.TabIndex = 10;
            this.txt_bitmapPool.Text = "1";
            // 
            // pnl_color
            // 
            this.pnl_color.BackColor = System.Drawing.Color.Black;
            this.pnl_color.Location = new System.Drawing.Point(521, 155);
            this.pnl_color.Name = "pnl_color";
            this.pnl_color.Size = new System.Drawing.Size(80, 20);
            this.pnl_color.TabIndex = 38;
            // 
            // btn_colorPick
            // 
            this.btn_colorPick.Location = new System.Drawing.Point(433, 154);
            this.btn_colorPick.Name = "btn_colorPick";
            this.btn_colorPick.Size = new System.Drawing.Size(84, 21);
            this.btn_colorPick.TabIndex = 5;
            this.btn_colorPick.Text = "Color";
            this.btn_colorPick.UseVisualStyleBackColor = true;
            this.btn_colorPick.Click += new System.EventHandler(this.btn_colorPick_Click);
            // 
            // bWorker
            // 
            this.bWorker.WorkerReportsProgress = true;
            this.bWorker.WorkerSupportsCancellation = true;
            this.bWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWorker_DoWork);
            this.bWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bWorker_ProgressChanged);
            this.bWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWorker_RunWorkerCompleted);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(302, 222);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(299, 58);
            this.btn_stop.TabIndex = 39;
            this.btn_stop.Text = "Stop Generation";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Visible = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(611, 322);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_colorPick);
            this.Controls.Add(this.pnl_color);
            this.Controls.Add(this.lbl_bitmapPool);
            this.Controls.Add(this.txt_bitmapPool);
            this.Controls.Add(this.lbl_threads);
            this.Controls.Add(this.txt_threads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_outextension);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Font);
            this.Controls.Add(this.lbl_lastIndex);
            this.Controls.Add(this.txt_lastIndex);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.txt_openFile);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.prbar);
            this.Controls.Add(this.btn_fontSelector);
            this.Controls.Add(this.txt_fontSelector);
            this.Controls.Add(this.lbl_opacity);
            this.Controls.Add(this.txt_opacity);
            this.Controls.Add(this.trbr_opacity);
            this.Controls.Add(this.lbl_outputFolder);
            this.Controls.Add(this.lbl_transparentFolder);
            this.Controls.Add(this.lbl_imageFolder);
            this.Controls.Add(this.txt_outputFolder);
            this.Controls.Add(this.txt_transparentFolder);
            this.Controls.Add(this.txt_imageFolder);
            this.Controls.Add(this.btn_outputFolder);
            this.Controls.Add(this.btn_transparentFolder);
            this.Controls.Add(this.btn_imageFolder);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Superimposer";
            ((System.ComponentModel.ISupportInitialize)(this.trbr_opacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog imageFolder;
        private System.Windows.Forms.FolderBrowserDialog transparentFolder;
        private System.Windows.Forms.Button btn_imageFolder;
        private System.Windows.Forms.Button btn_transparentFolder;
        private System.Windows.Forms.Button btn_outputFolder;
        private System.Windows.Forms.FolderBrowserDialog outputFolder;
        private System.Windows.Forms.TextBox txt_imageFolder;
        private System.Windows.Forms.TextBox txt_transparentFolder;
        private System.Windows.Forms.TextBox txt_outputFolder;
        private System.Windows.Forms.Label lbl_imageFolder;
        private System.Windows.Forms.Label lbl_transparentFolder;
        private System.Windows.Forms.Label lbl_outputFolder;
        private System.Windows.Forms.TrackBar trbr_opacity;
        private System.Windows.Forms.TextBox txt_opacity;
        private System.Windows.Forms.Label lbl_opacity;
        private System.Windows.Forms.FontDialog fontSelector;
        private System.Windows.Forms.TextBox txt_fontSelector;
        private System.Windows.Forms.Button btn_fontSelector;
        private System.Windows.Forms.ProgressBar prbar;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txt_openFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.TextBox txt_lastIndex;
        private System.Windows.Forms.Label lbl_lastIndex;
        private System.Windows.Forms.Label lbl_Font;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.Label lbl_filename;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.ComboBox cbb_outextension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_threads;
        private System.Windows.Forms.Label lbl_threads;
        private System.Windows.Forms.Label lbl_bitmapPool;
        private System.Windows.Forms.TextBox txt_bitmapPool;
        private System.Windows.Forms.Panel pnl_color;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button btn_colorPick;
        private System.ComponentModel.BackgroundWorker bWorker;
        private System.Windows.Forms.Button btn_stop;
    }
}

