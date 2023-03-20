namespace src
{
    partial class GUI
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
            this.lbl_filename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_BFS = new System.Windows.Forms.RadioButton();
            this.rdo_DFS = new System.Windows.Forms.RadioButton();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_visualize = new System.Windows.Forms.Button();
            this.ofd_browseFile = new System.Windows.Forms.OpenFileDialog();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Font = new System.Drawing.Font("DM Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_filename.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_filename.Location = new System.Drawing.Point(50, 108);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(203, 37);
            this.lbl_filename.TabIndex = 0;
            this.lbl_filename.Text = "Insert file path";
            this.lbl_filename.Click += new System.EventHandler(this.lbl_filename_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(50, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select customization";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rdo_BFS
            // 
            this.rdo_BFS.AutoSize = true;
            this.rdo_BFS.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdo_BFS.Location = new System.Drawing.Point(45, 58);
            this.rdo_BFS.Name = "rdo_BFS";
            this.rdo_BFS.Size = new System.Drawing.Size(66, 29);
            this.rdo_BFS.TabIndex = 5;
            this.rdo_BFS.TabStop = true;
            this.rdo_BFS.Text = "BFS";
            this.rdo_BFS.UseVisualStyleBackColor = true;
            this.rdo_BFS.CheckedChanged += new System.EventHandler(this.rdo_BFS_CheckedChanged);
            // 
            // rdo_DFS
            // 
            this.rdo_DFS.AutoSize = true;
            this.rdo_DFS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdo_DFS.Location = new System.Drawing.Point(45, 104);
            this.rdo_DFS.Name = "rdo_DFS";
            this.rdo_DFS.Size = new System.Drawing.Size(69, 29);
            this.rdo_DFS.TabIndex = 7;
            this.rdo_DFS.TabStop = true;
            this.rdo_DFS.Text = "DFS";
            this.rdo_DFS.UseVisualStyleBackColor = true;
            this.rdo_DFS.CheckedChanged += new System.EventHandler(this.btn_DFS_CheckedChanged);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(395, 255);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(153, 47);
            this.btn_browse.TabIndex = 8;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(254)))));
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_visualize
            // 
            this.btn_visualize.Location = new System.Drawing.Point(167, 669);
            this.btn_visualize.Name = "btn_visualize";
            this.btn_visualize.Size = new System.Drawing.Size(246, 47);
            this.btn_visualize.TabIndex = 9;
            this.btn_visualize.Text = "Visualize";
            this.btn_visualize.UseVisualStyleBackColor = true;
            this.btn_visualize.Click += new System.EventHandler(this.btn_visualize_Click);
            // 
            // ofd_browseFile
            // 
            this.ofd_browseFile.FileName = "openFileDialog1";
            this.ofd_browseFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_browseFile_FileOk);
            // 
            // txt_filename
            // 
            this.txt_filename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txt_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filename.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_filename.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_filename.Location = new System.Drawing.Point(50, 164);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(498, 45);
            this.txt_filename.TabIndex = 11;
            this.txt_filename.TextChanged += new System.EventHandler(this.txt_filename_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.rdo_BFS);
            this.panel1.Controls.Add(this.rdo_DFS);
            this.panel1.Location = new System.Drawing.Point(50, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 204);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel2.Location = new System.Drawing.Point(315, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 204);
            this.panel2.TabIndex = 13;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(594, 744);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.btn_visualize);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_filename);
            this.Name = "GUI";
            this.Text = "Treasure Hunt";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_filename;
        private Label label3;
        private RadioButton rdo_BFS;
        private RadioButton rdo_DFS;
        private Button btn_browse;
        private Button btn_visualize;
        private OpenFileDialog ofd_browseFile;
        private TextBox txt_filename;
        private Panel panel1;
        private Panel panel2;
    }
}