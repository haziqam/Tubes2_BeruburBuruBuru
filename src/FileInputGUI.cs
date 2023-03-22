using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI;
using MetroSet_UI.Forms;

/*
NOTES
FileInputGUI form:
    size = 550; 750
    color = 35; 36; 41

btn_browse:
    color = 29; 95; 254

panel:
    size = 191; 227
    color = 51; 55; 66

*/

namespace src
{
    public partial class FileInputGUI : Form
    {
        private bool useDefaultPath; // default path: test folder
        private bool useBFS;
        private bool useDFS;
        private bool showSteps = false;
        private bool includeTSP = false;

        public FileInputGUI()
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
            int[,] PointSequence = { { 0, 0 }, { 0, 1 }, { 1, 1 }, { 2, 1 }, { 2, 2 }, { 2, 3 }, { 1, 3 } };
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

        private void txt_filename_Click(object sender, EventArgs e)
        {

        }

        private void lbl_showSteps_Click(object sender, EventArgs e)
        {

        }

        private void swtch_TSP_SwitchedChanged(object sender)
        {
            this.includeTSP = !this.includeTSP;
        }

        private void swtch_showSteps_SwitchedChanged(object sender)
        {
            this.showSteps = !this.showSteps;
            if (this.showSteps)
            {
                this.cbo_ms.Show();
            }
            else
            {
                this.cbo_ms.Hide();
            }
        }
    }
}
