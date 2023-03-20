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
    public partial class GUI : Form
    {
        private bool useDefaultPath; // default path: test folder
        private bool useBFS;
        private bool useDFS;
        private bool showSteps;

        public GUI()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }
        private void txt_filename_TextChanged(object sender, EventArgs e)
        {
            this.useDefaultPath = true;   
        }

        private void rdo_BFS_CheckedChanged(object sender, EventArgs e)
        {
            this.useBFS = true;
            this.useDFS = false;
        }

        private void btn_DFS_CheckedChanged(object sender, EventArgs e)
        {
            this.useDFS = true;
            this.useBFS = false;
        }

        private void lbl_filename_Click(object sender, EventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (ofd_browseFile.ShowDialog() == DialogResult.OK)
            {
                txt_filename.Text = ofd_browseFile.FileName;
                this.useDefaultPath = false;
            }

        }

        private void btn_visualize_Click(object sender, EventArgs e)
        {
            VisualizeMapGUI mapGUI = new();
            this.Hide();
            // To handle mapGUI form closing event (see MapGUI_FormClosing() method below)
            mapGUI.FormClosing += MapGUI_FormClosing;
            mapGUI.Show();
            mapGUI.initialize_dataGridView(4, 4);
            char[,] Map = {{'K', 'R', 'R', 'R'},
                           {'X', 'R', 'X', 'T'},
                           {'X', 'T', 'R', 'R'},
                           {'X', 'R', 'X', 'X'}};
            mapGUI.fill_map(Map);
        }

        private void ofd_browseFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MapGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            // To show FileInputGUI again after closing mapGUI
            ((VisualizeMapGUI)sender).FormClosing -= MapGUI_FormClosing;
            this.Show();
        }

    }
}
