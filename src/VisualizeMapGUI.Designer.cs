namespace src
{
    partial class VisualizeMapGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizeMapGUI));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_routeseq = new System.Windows.Forms.Label();
            this.lbl_route = new System.Windows.Forms.Label();
            this.lbl_exectime = new System.Windows.Forms.Label();
            this.lbl_steps = new System.Windows.Forms.Label();
            this.lbl_nodes = new System.Windows.Forms.Label();
            this.lbl_algorithm = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_namaKelompok = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(394, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(420, 360);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.lbl_routeseq);
            this.panel1.Controls.Add(this.lbl_route);
            this.panel1.Controls.Add(this.lbl_exectime);
            this.panel1.Controls.Add(this.lbl_steps);
            this.panel1.Controls.Add(this.lbl_nodes);
            this.panel1.Controls.Add(this.lbl_algorithm);
            this.panel1.Location = new System.Drawing.Point(59, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 311);
            this.panel1.TabIndex = 3;
            // 
            // lbl_routeseq
            // 
            this.lbl_routeseq.ForeColor = System.Drawing.Color.White;
            this.lbl_routeseq.Location = new System.Drawing.Point(27, 218);
            this.lbl_routeseq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_routeseq.Name = "lbl_routeseq";
            this.lbl_routeseq.Size = new System.Drawing.Size(239, 85);
            this.lbl_routeseq.TabIndex = 5;
            // 
            // lbl_route
            // 
            this.lbl_route.AutoSize = true;
            this.lbl_route.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_route.ForeColor = System.Drawing.Color.White;
            this.lbl_route.Location = new System.Drawing.Point(27, 188);
            this.lbl_route.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_route.Name = "lbl_route";
            this.lbl_route.Size = new System.Drawing.Size(56, 22);
            this.lbl_route.TabIndex = 4;
            this.lbl_route.Text = "Route:";
            // 
            // lbl_exectime
            // 
            this.lbl_exectime.AutoSize = true;
            this.lbl_exectime.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_exectime.ForeColor = System.Drawing.Color.White;
            this.lbl_exectime.Location = new System.Drawing.Point(27, 148);
            this.lbl_exectime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_exectime.Name = "lbl_exectime";
            this.lbl_exectime.Size = new System.Drawing.Size(124, 22);
            this.lbl_exectime.TabIndex = 3;
            this.lbl_exectime.Text = "Execution time: ";
            // 
            // lbl_steps
            // 
            this.lbl_steps.AutoSize = true;
            this.lbl_steps.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_steps.ForeColor = System.Drawing.Color.White;
            this.lbl_steps.Location = new System.Drawing.Point(27, 107);
            this.lbl_steps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_steps.Name = "lbl_steps";
            this.lbl_steps.Size = new System.Drawing.Size(58, 22);
            this.lbl_steps.TabIndex = 2;
            this.lbl_steps.Text = "Steps: ";
            // 
            // lbl_nodes
            // 
            this.lbl_nodes.AutoSize = true;
            this.lbl_nodes.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nodes.ForeColor = System.Drawing.Color.White;
            this.lbl_nodes.Location = new System.Drawing.Point(27, 67);
            this.lbl_nodes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nodes.Name = "lbl_nodes";
            this.lbl_nodes.Size = new System.Drawing.Size(65, 22);
            this.lbl_nodes.TabIndex = 1;
            this.lbl_nodes.Text = "Nodes: ";
            // 
            // lbl_algorithm
            // 
            this.lbl_algorithm.AutoSize = true;
            this.lbl_algorithm.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_algorithm.ForeColor = System.Drawing.Color.White;
            this.lbl_algorithm.Location = new System.Drawing.Point(27, 28);
            this.lbl_algorithm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_algorithm.Name = "lbl_algorithm";
            this.lbl_algorithm.Size = new System.Drawing.Size(87, 22);
            this.lbl_algorithm.TabIndex = 0;
            this.lbl_algorithm.Text = "Algorithm: ";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(254)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Open Sans", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(115, 421);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(226, 36);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "SEARCH!";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Gray;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(59, 421);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 36);
            this.btn_back.TabIndex = 4;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_namaKelompok
            // 
            this.lbl_namaKelompok.AutoSize = true;
            this.lbl_namaKelompok.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_namaKelompok.ForeColor = System.Drawing.Color.Gray;
            this.lbl_namaKelompok.Location = new System.Drawing.Point(78, 54);
            this.lbl_namaKelompok.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_namaKelompok.Name = "lbl_namaKelompok";
            this.lbl_namaKelompok.Size = new System.Drawing.Size(143, 15);
            this.lbl_namaKelompok.TabIndex = 24;
            this.lbl_namaKelompok.Text = "BY: BERUBUR BURU-BURU";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(70, 25);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(292, 33);
            this.lbl_title.TabIndex = 23;
            this.lbl_title.Text = "Treasure Hunt Solution";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.panel3.Location = new System.Drawing.Point(60, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 42);
            this.panel3.TabIndex = 22;
            // 
            // VisualizeMapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(881, 508);
            this.Controls.Add(this.lbl_namaKelompok);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisualizeMapGUI";
            this.Text = "TreasureHuntVisualizer";
            this.Load += new System.EventHandler(this.VisualizeMapGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btn_search;
        private Button btn_back;
        private Label lbl_routeseq;
        private Label lbl_route;
        private Label lbl_exectime;
        private Label lbl_steps;
        private Label lbl_nodes;
        private Label lbl_algorithm;
        private Label lbl_namaKelompok;
        private Label lbl_title;
        private Panel panel3;
    }
}