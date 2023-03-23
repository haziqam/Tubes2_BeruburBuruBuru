using System.Windows.Forms.VisualStyles;

namespace src
{
    partial class FileInputGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileInputGUI));
            this.lbl_filename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_BFS = new System.Windows.Forms.RadioButton();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_visualize = new System.Windows.Forms.Button();
            this.ofd_browseFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_algorithm = new System.Windows.Forms.Label();
            this.swtch_TSP = new MetroSet_UI.Controls.MetroSetSwitch();
            this.rdo_DFS = new System.Windows.Forms.RadioButton();
            this.lbl_TSP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_pausetime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_ms = new System.Windows.Forms.ComboBox();
            this.swtch_showSteps = new MetroSet_UI.Controls.MetroSetSwitch();
            this.lbl_showSteps = new System.Windows.Forms.Label();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_usedefaultpath = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Font = new System.Drawing.Font("Open Sans Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_filename.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_filename.Location = new System.Drawing.Point(101, 80);
            this.lbl_filename.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(197, 38);
            this.lbl_filename.TabIndex = 0;
            this.lbl_filename.Text = "Insert file path";
            this.lbl_filename.Click += new System.EventHandler(this.lbl_filename_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(101, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select customization";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rdo_BFS
            // 
            this.rdo_BFS.AutoSize = true;
            this.rdo_BFS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdo_BFS.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdo_BFS.Location = new System.Drawing.Point(20, 66);
            this.rdo_BFS.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.rdo_BFS.Name = "rdo_BFS";
            this.rdo_BFS.Size = new System.Drawing.Size(78, 36);
            this.rdo_BFS.TabIndex = 5;
            this.rdo_BFS.TabStop = true;
            this.rdo_BFS.Text = "BFS";
            this.rdo_BFS.UseVisualStyleBackColor = true;
            this.rdo_BFS.CheckedChanged += new System.EventHandler(this.rdo_BFS_CheckedChanged);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(254)))));
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_browse.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_browse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_browse.Location = new System.Drawing.Point(305, 207);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(187, 47);
            this.btn_browse.TabIndex = 8;
            this.btn_browse.Text = "BROWSE";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_visualize
            // 
            this.btn_visualize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(254)))));
            this.btn_visualize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_visualize.Font = new System.Drawing.Font("Open Sans", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_visualize.ForeColor = System.Drawing.Color.White;
            this.btn_visualize.Location = new System.Drawing.Point(152, 634);
            this.btn_visualize.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_visualize.Name = "btn_visualize";
            this.btn_visualize.Size = new System.Drawing.Size(206, 48);
            this.btn_visualize.TabIndex = 9;
            this.btn_visualize.Text = "VISUALIZE!";
            this.btn_visualize.UseVisualStyleBackColor = false;
            this.btn_visualize.Click += new System.EventHandler(this.btn_visualize_Click);
            // 
            // ofd_browseFile
            // 
            this.ofd_browseFile.FileName = "openFileDialog1";
            this.ofd_browseFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_browseFile_FileOk);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.lbl_algorithm);
            this.panel1.Controls.Add(this.swtch_TSP);
            this.panel1.Controls.Add(this.rdo_DFS);
            this.panel1.Controls.Add(this.lbl_TSP);
            this.panel1.Controls.Add(this.rdo_BFS);
            this.panel1.Location = new System.Drawing.Point(46, 354);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 250);
            this.panel1.TabIndex = 12;
            // 
            // lbl_algorithm
            // 
            this.lbl_algorithm.AutoSize = true;
            this.lbl_algorithm.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_algorithm.ForeColor = System.Drawing.Color.Gray;
            this.lbl_algorithm.Location = new System.Drawing.Point(43, 18);
            this.lbl_algorithm.Name = "lbl_algorithm";
            this.lbl_algorithm.Size = new System.Drawing.Size(111, 24);
            this.lbl_algorithm.TabIndex = 12;
            this.lbl_algorithm.Text = "ALGORITHM";
            this.lbl_algorithm.Click += new System.EventHandler(this.lbl_algorithm_Click);
            // 
            // swtch_TSP
            // 
            this.swtch_TSP.BackColor = System.Drawing.Color.Transparent;
            this.swtch_TSP.BackgroundColor = System.Drawing.Color.Empty;
            this.swtch_TSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.swtch_TSP.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.swtch_TSP.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.swtch_TSP.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.swtch_TSP.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.swtch_TSP.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.swtch_TSP.IsDerivedStyle = true;
            this.swtch_TSP.Location = new System.Drawing.Point(22, 200);
            this.swtch_TSP.Name = "swtch_TSP";
            this.swtch_TSP.Size = new System.Drawing.Size(58, 22);
            this.swtch_TSP.Style = MetroSet_UI.Enums.Style.Light;
            this.swtch_TSP.StyleManager = null;
            this.swtch_TSP.Switched = false;
            this.swtch_TSP.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.swtch_TSP.TabIndex = 11;
            this.swtch_TSP.Text = "metroSetSwitch1";
            this.swtch_TSP.ThemeAuthor = "Narwin";
            this.swtch_TSP.ThemeName = "MetroLite";
            this.swtch_TSP.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.swtch_TSP.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.swtch_TSP_SwitchedChanged);
            // 
            // rdo_DFS
            // 
            this.rdo_DFS.AutoSize = true;
            this.rdo_DFS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdo_DFS.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdo_DFS.Location = new System.Drawing.Point(20, 130);
            this.rdo_DFS.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.rdo_DFS.Name = "rdo_DFS";
            this.rdo_DFS.Size = new System.Drawing.Size(81, 36);
            this.rdo_DFS.TabIndex = 9;
            this.rdo_DFS.TabStop = true;
            this.rdo_DFS.Text = "DFS";
            this.rdo_DFS.UseVisualStyleBackColor = true;
            // 
            // lbl_TSP
            // 
            this.lbl_TSP.AutoSize = true;
            this.lbl_TSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TSP.Location = new System.Drawing.Point(101, 194);
            this.lbl_TSP.Name = "lbl_TSP";
            this.lbl_TSP.Size = new System.Drawing.Size(53, 32);
            this.lbl_TSP.TabIndex = 10;
            this.lbl_TSP.Text = "TSP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.lbl_pausetime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbo_ms);
            this.panel2.Controls.Add(this.swtch_showSteps);
            this.panel2.Controls.Add(this.lbl_showSteps);
            this.panel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Location = new System.Drawing.Point(295, 354);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 250);
            this.panel2.TabIndex = 13;
            // 
            // lbl_pausetime
            // 
            this.lbl_pausetime.AutoSize = true;
            this.lbl_pausetime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pausetime.Location = new System.Drawing.Point(17, 147);
            this.lbl_pausetime.Name = "lbl_pausetime";
            this.lbl_pausetime.Size = new System.Drawing.Size(130, 32);
            this.lbl_pausetime.TabIndex = 17;
            this.lbl_pausetime.Text = "Pause time";
            this.lbl_pausetime.Click += new System.EventHandler(this.lbl_pausetime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "VISUALIZATION";
            // 
            // cbo_ms
            // 
            this.cbo_ms.BackColor = System.Drawing.Color.Silver;
            this.cbo_ms.FormattingEnabled = true;
            this.cbo_ms.Items.AddRange(new object[] {
            "250 ms",
            "500 ms",
            "1000 ms",
            "2000 ms"});
            this.cbo_ms.Location = new System.Drawing.Point(21, 195);
            this.cbo_ms.Name = "cbo_ms";
            this.cbo_ms.Size = new System.Drawing.Size(119, 33);
            this.cbo_ms.TabIndex = 16;
            this.cbo_ms.SelectedIndexChanged += new System.EventHandler(this.cbo_ms_SelectedIndexChanged);
            // 
            // swtch_showSteps
            // 
            this.swtch_showSteps.BackColor = System.Drawing.Color.Transparent;
            this.swtch_showSteps.BackgroundColor = System.Drawing.Color.Empty;
            this.swtch_showSteps.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.swtch_showSteps.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.swtch_showSteps.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.swtch_showSteps.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.swtch_showSteps.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.swtch_showSteps.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.swtch_showSteps.IsDerivedStyle = true;
            this.swtch_showSteps.Location = new System.Drawing.Point(22, 111);
            this.swtch_showSteps.Name = "swtch_showSteps";
            this.swtch_showSteps.Size = new System.Drawing.Size(58, 22);
            this.swtch_showSteps.Style = MetroSet_UI.Enums.Style.Light;
            this.swtch_showSteps.StyleManager = null;
            this.swtch_showSteps.Switched = false;
            this.swtch_showSteps.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.swtch_showSteps.TabIndex = 12;
            this.swtch_showSteps.Text = "metroSetSwitch1";
            this.swtch_showSteps.ThemeAuthor = "Narwin";
            this.swtch_showSteps.ThemeName = "MetroLite";
            this.swtch_showSteps.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.swtch_showSteps.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.swtch_showSteps_SwitchedChanged);
            // 
            // lbl_showSteps
            // 
            this.lbl_showSteps.AutoSize = true;
            this.lbl_showSteps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_showSteps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_showSteps.Location = new System.Drawing.Point(16, 63);
            this.lbl_showSteps.Name = "lbl_showSteps";
            this.lbl_showSteps.Size = new System.Drawing.Size(134, 32);
            this.lbl_showSteps.TabIndex = 11;
            this.lbl_showSteps.Text = "Show steps";
            this.lbl_showSteps.Click += new System.EventHandler(this.lbl_showSteps_Click);
            // 
            // txt_filename
            // 
            this.txt_filename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txt_filename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_filename.Font = new System.Drawing.Font("Open Sans Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_filename.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_filename.Location = new System.Drawing.Point(36, 130);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(456, 39);
            this.txt_filename.TabIndex = 15;
            this.txt_filename.TextChanged += new System.EventHandler(this.txt_filename_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_usedefaultpath
            // 
            this.lbl_usedefaultpath.AutoSize = true;
            this.lbl_usedefaultpath.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_usedefaultpath.ForeColor = System.Drawing.Color.Red;
            this.lbl_usedefaultpath.Location = new System.Drawing.Point(39, 176);
            this.lbl_usedefaultpath.Name = "lbl_usedefaultpath";
            this.lbl_usedefaultpath.Size = new System.Drawing.Size(212, 21);
            this.lbl_usedefaultpath.TabIndex = 18;
            this.lbl_usedefaultpath.Text = "use default path (test folder): ";
            // 
            // FileInputGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(528, 711);
            this.Controls.Add(this.lbl_usedefaultpath);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_visualize);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_filename);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FileInputGUI";
            this.Text = "TreasureHunt";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_filename;
        private Label label3;
        private RadioButton rdo_BFS;
        private Button btn_browse;
        private Button btn_visualize;
        private OpenFileDialog ofd_browseFile;
        private Panel panel1;
        private Panel panel2;
        private RadioButton rdo_DFS;
        private TextBox txt_filename;
        private Label lbl_TSP;
        private Label lbl_showSteps;
        private MetroSet_UI.Controls.MetroSetSwitch swtch_TSP;
        private MetroSet_UI.Controls.MetroSetSwitch swtch_showSteps;
        private ComboBox cbo_ms;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbl_algorithm;
        private Label label1;
        private Label lbl_pausetime;
        private Label lbl_usedefaultpath;
    }
}