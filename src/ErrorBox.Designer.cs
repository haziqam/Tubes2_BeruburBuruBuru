namespace src
{
    partial class ErrorBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_errorFound = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_errorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_errorFound
            // 
            this.lbl_errorFound.AutoSize = true;
            this.lbl_errorFound.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorFound.ForeColor = System.Drawing.Color.White;
            this.lbl_errorFound.Location = new System.Drawing.Point(100, 33);
            this.lbl_errorFound.Name = "lbl_errorFound";
            this.lbl_errorFound.Size = new System.Drawing.Size(153, 33);
            this.lbl_errorFound.TabIndex = 1;
            this.lbl_errorFound.Text = "Error found";
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(254)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OK.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(146, 181);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(142, 43);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_errorMsg
            // 
            this.lbl_errorMsg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorMsg.ForeColor = System.Drawing.Color.White;
            this.lbl_errorMsg.Location = new System.Drawing.Point(27, 97);
            this.lbl_errorMsg.Name = "lbl_errorMsg";
            this.lbl_errorMsg.Size = new System.Drawing.Size(364, 64);
            this.lbl_errorMsg.TabIndex = 4;
            // 
            // ErrorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(433, 239);
            this.Controls.Add(this.lbl_errorMsg);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_errorFound);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ErrorBox";
            this.Text = "ErrorBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_errorFound;
        private Button btn_OK;
        private Label lbl_errorMsg;
    }
}