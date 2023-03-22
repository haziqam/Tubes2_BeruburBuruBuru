using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src
{
    public partial class ErrorBox : Form
    {
        public ErrorBox()
        {
            InitializeComponent();
        }

        public void setErrorMsg(string errorMsg)
        {
            this.lbl_errorMsg.Text = errorMsg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
