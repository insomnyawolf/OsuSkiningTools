namespace OsuSkinningTools
{
    partial class OsuSkinningToolsWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SelectWorkingDir = new System.Windows.Forms.Button();
            this.lbl_WorkingDirectory = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_HDtoSD = new System.Windows.Forms.Button();
            this.lbl_HDtoSD = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_CleanLowResAssets = new System.Windows.Forms.Button();
            this.lbl_CleanLowResAssets = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox_progressBar = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_progressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SelectWorkingDir);
            this.groupBox1.Controls.Add(this.lbl_WorkingDirectory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Working Directory";
            // 
            // btn_SelectWorkingDir
            // 
            this.btn_SelectWorkingDir.Location = new System.Drawing.Point(13, 23);
            this.btn_SelectWorkingDir.Name = "btn_SelectWorkingDir";
            this.btn_SelectWorkingDir.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectWorkingDir.TabIndex = 1;
            this.btn_SelectWorkingDir.Text = "Select";
            this.btn_SelectWorkingDir.UseVisualStyleBackColor = true;
            this.btn_SelectWorkingDir.Click += new System.EventHandler(this.Btn_SelectWorkingDir_Click);
            // 
            // lbl_WorkingDirectory
            // 
            this.lbl_WorkingDirectory.AutoSize = true;
            this.lbl_WorkingDirectory.Location = new System.Drawing.Point(94, 27);
            this.lbl_WorkingDirectory.Name = "lbl_WorkingDirectory";
            this.lbl_WorkingDirectory.Size = new System.Drawing.Size(140, 15);
            this.lbl_WorkingDirectory.TabIndex = 0;
            this.lbl_WorkingDirectory.Text = "Please select a skin folder";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 259);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_HDtoSD);
            this.tabPage2.Controls.Add(this.lbl_HDtoSD);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(404, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hd to Sd";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_HDtoSD
            // 
            this.btn_HDtoSD.Location = new System.Drawing.Point(9, 23);
            this.btn_HDtoSD.Name = "btn_HDtoSD";
            this.btn_HDtoSD.Size = new System.Drawing.Size(75, 23);
            this.btn_HDtoSD.TabIndex = 1;
            this.btn_HDtoSD.Text = "Create It";
            this.btn_HDtoSD.UseVisualStyleBackColor = true;
            this.btn_HDtoSD.Click += new System.EventHandler(this.Btn_HDtoSD_Click);
            // 
            // lbl_HDtoSD
            // 
            this.lbl_HDtoSD.AutoSize = true;
            this.lbl_HDtoSD.Location = new System.Drawing.Point(9, 4);
            this.lbl_HDtoSD.Name = "lbl_HDtoSD";
            this.lbl_HDtoSD.Size = new System.Drawing.Size(309, 15);
            this.lbl_HDtoSD.TabIndex = 0;
            this.lbl_HDtoSD.Text = "This will creaty a copy of every @2x file with sd resolution";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_CleanLowResAssets);
            this.tabPage1.Controls.Add(this.lbl_CleanLowResAssets);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(404, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clean Low Res Assets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_CleanLowResAssets
            // 
            this.btn_CleanLowResAssets.Location = new System.Drawing.Point(9, 34);
            this.btn_CleanLowResAssets.Name = "btn_CleanLowResAssets";
            this.btn_CleanLowResAssets.Size = new System.Drawing.Size(75, 23);
            this.btn_CleanLowResAssets.TabIndex = 1;
            this.btn_CleanLowResAssets.Text = "Clean It";
            this.btn_CleanLowResAssets.UseVisualStyleBackColor = true;
            this.btn_CleanLowResAssets.Click += new System.EventHandler(this.Btn_CleanLowResAssets_Click);
            // 
            // lbl_CleanLowResAssets
            // 
            this.lbl_CleanLowResAssets.AutoSize = true;
            this.lbl_CleanLowResAssets.Location = new System.Drawing.Point(9, 15);
            this.lbl_CleanLowResAssets.Name = "lbl_CleanLowResAssets";
            this.lbl_CleanLowResAssets.Size = new System.Drawing.Size(365, 15);
            this.lbl_CleanLowResAssets.TabIndex = 0;
            this.lbl_CleanLowResAssets.Text = "This will delete every low resolution asset that have an hd equivalent";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(404, 231);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compile";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(404, 231);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            // 
            // groupBox_progressBar
            // 
            this.groupBox_progressBar.Controls.Add(this.progressBar);
            this.groupBox_progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_progressBar.Location = new System.Drawing.Point(0, 267);
            this.groupBox_progressBar.Name = "groupBox_progressBar";
            this.groupBox_progressBar.Size = new System.Drawing.Size(412, 48);
            this.groupBox_progressBar.TabIndex = 2;
            this.groupBox_progressBar.TabStop = false;
            this.groupBox_progressBar.Text = "Progress";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 19);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(406, 26);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // OsuSkinningToolsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 315);
            this.Controls.Add(this.groupBox_progressBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OsuSkinningToolsWindow";
            this.Text = "OsuSkinningTools";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox_progressBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SelectWorkingDir;
        private System.Windows.Forms.Label lbl_WorkingDirectory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbl_CleanLowResAssets;
        private System.Windows.Forms.GroupBox groupBox_progressBar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btn_CleanLowResAssets;
        private System.Windows.Forms.Button btn_HDtoSD;
        private System.Windows.Forms.Label lbl_HDtoSD;
    }
}