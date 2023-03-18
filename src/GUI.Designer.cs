﻿namespace src
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
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_BFS = new System.Windows.Forms.RadioButton();
            this.rdo_DFS = new System.Windows.Forms.RadioButton();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_visualize = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_filename.Location = new System.Drawing.Point(67, 96);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(193, 54);
            this.lbl_filename.TabIndex = 0;
            this.lbl_filename.Text = "File name";
            this.lbl_filename.Click += new System.EventHandler(this.lbl_filename_Click);
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(67, 183);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(373, 31);
            this.txt_filename.TabIndex = 1;
            this.txt_filename.TextChanged += new System.EventHandler(this.inputFileTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "Algorithm";
            // 
            // rdo_BFS
            // 
            this.rdo_BFS.AutoSize = true;
            this.rdo_BFS.Location = new System.Drawing.Point(76, 425);
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
            this.rdo_DFS.Location = new System.Drawing.Point(76, 470);
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
            this.btn_browse.Location = new System.Drawing.Point(328, 245);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(112, 34);
            this.btn_browse.TabIndex = 8;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_visualize
            // 
            this.btn_visualize.Location = new System.Drawing.Point(76, 551);
            this.btn_visualize.Name = "btn_visualize";
            this.btn_visualize.Size = new System.Drawing.Size(112, 34);
            this.btn_visualize.TabIndex = 9;
            this.btn_visualize.Text = "Visualize";
            this.btn_visualize.UseVisualStyleBackColor = true;
            this.btn_visualize.Click += new System.EventHandler(this.btn_visualize_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(536, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(675, 580);
            this.dataGridView1.TabIndex = 10;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_visualize);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.rdo_DFS);
            this.Controls.Add(this.rdo_BFS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.lbl_filename);
            this.Name = "GUI";
            this.Text = "Treasure Hunt";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_filename;
        private TextBox txt_filename;
        private Label label3;
        private RadioButton rdo_BFS;
        private RadioButton rdo_DFS;
        private Button btn_browse;
        private Button btn_visualize;
        private DataGridView dataGridView1;
    }
}