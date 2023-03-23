using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Enums;

namespace src
{
    public partial class VisualizeMapGUI : Form
    {
        // Reference to file input window, supaya bisa dapetin data dari file input GUI dan 
        // Show file input window setelah klik tombol back
        private FileInputGUI fileInputGUI;

        // Reference to treasureHunt, supaya bisa dapetin data peta dan method2 yang diperlukan
        // private TreasureHunt treasureHunt;

        public VisualizeMapGUI(FileInputGUI fileInputGUI /*, TreasureHunt treasureHunt*/)
        {
            InitializeComponent();
            this.Show();

            // Assign attributes
            this.fileInputGUI = fileInputGUI;
            //this.treasureHunt = treasureHunt;

            // Write algorithm to the screen
            if (this.fileInputGUI.useBFS)
            {
                this.lbl_algorithm.Text += " BFS";
            }
            else
            {
                this.lbl_algorithm.Text += "DFS";
            }

            if (this.fileInputGUI.includeTSP)
            {
                this.lbl_algorithm.Text += " + TSP";
            }

            // Initialize grid view
            initialize_dataGridView(3, 4);
            string[,] Map = {{"K", "R", "R", "R"},
                               {"X", "R", "X", "T"},
                               {"X", "T", "R", "R"}};
            fill_map(Map);

        }

        private void VisualizeMapGUI_Load(object sender, EventArgs e)
        {

        }

        public void initialize_dataGridView(int rows, int cols)
        {
            this.dataGridView1.RowCount = rows;
            this.dataGridView1.ColumnCount = cols;
            int height;

            if (rows == cols)
            {
                height = this.dataGridView1.Columns[0].Width;
            }
            else
            {
                height = this.dataGridView1.Height / rows;
            }
            
            foreach (DataGridViewRow x in this.dataGridView1.Rows)
            {
                x.MinimumHeight = height;
            }

            this.dataGridView1.CurrentCell = null;
        }


        //TO-DO: ganti parameter char[,] ke Peta
        public void fill_map(string[,] Map)
        {
            // Change font, font size, and text alignment
            dataGridView1.DefaultCellStyle.Font = new Font("Open Sans", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < this.dataGridView1.ColumnCount; j++)
                {
                    if (Map[i, j] == "X")
                    {
                        this.dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                    }
                    else if (Map[i, j] == "K")
                    {
                        this.dataGridView1.Rows[i].Cells[j].Value = "START";
                    }
                    else if (Map[i, j] == "T")
                    {
                        this.dataGridView1.Rows[i].Cells[j].Value = "TREAUSRE";
                    }
                }
            }
        }

        //TO-DO: ganti parameter char[,] ke Peta
        public void show_solution(string[,] Map)
        {
            /* Color assignment
             Solution route => yellow */
            Color solutionRoute = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(181)))), ((int)(((byte)(5)))));

            // Color all nodes that belong to solution route
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < this.dataGridView1.ColumnCount; j++)
                {
                    // if node belong to solution route => color it
                }
            }
        }

        //TO-DO: ganti parameter int[,] ke List<int[]>
        public async Task show_progress(int[,] PointSequence)
        {
            // Get pause time
            int pauseTime = this.fileInputGUI.pauseTime;

            /* Color assignment
            Node being checked => darker blue
            Nodes already checked => lighter blue */

            Color beingChecked = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(163)))), ((int)(((byte)(166)))));
            Color alreadyChecked = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));

            // Start coloring process
            for (int i = 0; i < PointSequence.GetLength(0); i++)
            {
                if (i != 0)
                {
                    // Mark nodes already checked
                    int prevRow = PointSequence[i - 1, 0];
                    int prevCol = PointSequence[i - 1, 1];
                    this.dataGridView1.Rows[prevRow].Cells[prevCol].Style.BackColor = alreadyChecked;
                }

                // Mark nodes being checked
                int row = PointSequence[i, 0];
                int col = PointSequence[i, 1];
                this.dataGridView1.Rows[row].Cells[col].Style.BackColor = beingChecked;
                await Task.Delay(pauseTime);
            }

            // Mark last node as checked
            int lastRow = PointSequence[PointSequence.GetLength(0) - 1, 0];
            int lastCol = PointSequence[PointSequence.GetLength(0) - 1, 1];
            this.dataGridView1.Rows[lastRow].Cells[lastCol].Style.BackColor = alreadyChecked;
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (this.fileInputGUI.showSteps) 
            {
                int[,] PointSequence = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 1, 0 }, { 0, 3 }, { 2, 1 } };
                show_progress(PointSequence);
            }
            
            // Show solution

            // Write nodes, stpes, execution time, and route to the screen
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.fileInputGUI.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
