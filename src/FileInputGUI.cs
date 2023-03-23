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
        public bool useDefaultPath { get; private set; } = true; // default path: test folder
        public bool useBFS { get; private set; } = false;
        public bool useDFS { get; private set; } = false;
        public bool showSteps { get; private set; } = false;
        public bool includeTSP { get; private set; } = false;

        public FileInputGUI()
        {
            InitializeComponent();
            this.lbl_pausetime.Hide();
            this.cbo_ms.Hide();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void GUI_Load(object sender, EventArgs e)
        {

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
                this.lbl_usedefaultpath.Text = "use default path (test folder): False";
            }

        }

        private void btn_visualize_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string errorMsg = "";

            // Detect early error from GUI
            if (this.txt_filename.Text == "")
            {
                isError = true;
                errorMsg = "File name can't be empty!";
            }

            else if (!this.useBFS && !this.useDFS)
            {
                isError = true;
                errorMsg = "Please pick either BFS or DFS!";
            }

            else if (this.showSteps && this.cbo_ms.SelectedIndex == -1)
            {
                isError = true;
                errorMsg = "Please pick pause time if you wish to show steps!";
            }

            TreasureHunt treasureHunt;
            string filePath;

            // Try opening file path
            try
            {
                filePath = txt_filename.Text;
                if (this.useDefaultPath)
                {
                    // Nanti pas bin nya dipindahin, ini jadi gini
                    // filePath = "../test/" + filePath;
                    filePath = "../../../../test/" + filePath;
                }
                
                treasureHunt = new TreasureHunt(filePath);

            }
            catch(Exception err)
            {
                isError = true;
                errorMsg = err.Message;
            }
            
            if (isError)
            {
                // Show error box
                ErrorBox errorBox = new();
                errorBox.setErrorMsg(errorMsg);
                errorBox.ShowDialog();
            }
            else
            {
                // Change window to visualizeMapGUI
                this.Hide();
                VisualizeMapGUI mapGUI = new(this);

                // To handle mapGUI form closing event (see MapGUI_FormClosing() method below)
                mapGUI.FormClosing += MapGUI_FormClosing;
            }

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
                this.lbl_pausetime.Show();
                this.cbo_ms.Show();
            }
            else
            {
                this.lbl_pausetime.Hide();
                this.cbo_ms.Hide();
            }
        }

        private void lbl_algorithm_Click(object sender, EventArgs e)
        {

        }

        private void cbo_ms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pausetime_Click(object sender, EventArgs e)
        {

        }

        private void txt_filename_TextChanged_1(object sender, EventArgs e)
        {
            this.useDefaultPath = true;
            this.lbl_usedefaultpath.Text = "use default path (test folder): True";
        }
    }
}
