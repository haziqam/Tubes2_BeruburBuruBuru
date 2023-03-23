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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace src
{
    partial class VisualizeMapGUI : Form
    {
        // Reference to file input window, supaya bisa dapetin data dari file input GUI dan 
        // Show file input window setelah klik tombol back
        private FileInputGUI fileInputGUI;

        // Reference to treasureHunt, supaya bisa dapetin data peta dan method2 yang diperlukan
        private TreasureHunt treasureHunt;

        public VisualizeMapGUI(FileInputGUI fileInputGUI , TreasureHunt treasureHunt)
        {
            InitializeComponent();
            this.Show();

            // Assign attributes
            this.fileInputGUI = fileInputGUI;
            this.treasureHunt = treasureHunt;

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
            initialize_dataGridView(this.treasureHunt.Row, this.treasureHunt.Col);
            
            // Fill map
            fill_map();

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
        public void fill_map()
        {
            // Change font, font size, and text alignment
            dataGridView1.DefaultCellStyle.Font = new Font("Open Sans", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Fill each cells of datagrid
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < this.dataGridView1.ColumnCount; j++)
                {
                    if (this.treasureHunt[i, j] == TreasureSymbols.BLOCK)
                    {
                        this.dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                    }
                    else if (this.treasureHunt[i, j] == TreasureSymbols.START)
                    {
                        this.dataGridView1.Rows[i].Cells[j].Value = "🚩";
                    }
                    else if (this.treasureHunt[i, j] == TreasureSymbols.TREASURE)
                    {
                        this.dataGridView1.Rows[i].Cells[j].Value = "💰";
                    }
                }
            }
        }

        public void show_solution(List<Node> route)
        {
            /* Color assignment
             Solution route => yellow */
            Color solutionRouteColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(181)))), ((int)(((byte)(5)))));

            (int startRow, int startCol) = this.treasureHunt.StartPosition;
            this.dataGridView1.Rows[startRow].Cells[startCol].Style.BackColor = solutionRouteColor;

            // Color all nodes that belong to solution route
            this.lbl_routeseq.Text = "START";

            foreach (Node node in route) 
            {
                int row = node.row;
                int col = node.col;
                char choice = node.choice;
                this.dataGridView1.Rows[row].Cells[col].Style.BackColor = solutionRouteColor;
                this.lbl_routeseq.Text += " - " + choice;
            }
        }

        public async Task show_progress()
        {
            List<List<Position>> PointSequence = this.treasureHunt.SearchSequence;

            // Get pause time
            int pauseTime = this.fileInputGUI.pauseTime;

            /* Color assignment
            Node being checked => darker blue
            Nodes already checked => lighter blue 
            Treasure node => red*/

            Color beingCheckedColor = Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(163)))), ((int)(((byte)(166)))));
            Color alreadyCheckedColor = Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            Color treasureNodeColor = Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(80)))), ((int)(((byte)(74)))));
            Color initialGridColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

            foreach (List<Position> trace in PointSequence)
            {
                bool previousTreasure = false;
                for (int i = 0; i < trace.Count; i++)
                {
                    
                    if (i != 0)
                    {
                        int prevRow = trace[i - 1].row;
                        int prevCol = trace[i - 1].col;
                        

                        if (previousTreasure)
                        {
                            this.dataGridView1.Rows[prevRow].Cells[prevCol].Style.BackColor = treasureNodeColor;
                        }
                        else
                        {
                            this.dataGridView1.Rows[prevRow].Cells[prevCol].Style.BackColor = alreadyCheckedColor;
                        }
                    }
                    int currentRow = trace[i].row;
                    int currentCol = trace[i].col;
                    previousTreasure = (this.dataGridView1.Rows[currentRow].Cells[currentCol].Style.BackColor == treasureNodeColor);
                    this.dataGridView1.Rows[currentRow].Cells[currentCol].Style.BackColor = beingCheckedColor;
                    await Task.Delay(pauseTime);
                }
                // set treasure node with treasure color
                Position lastNode = trace.Last();
                this.dataGridView1.Rows[lastNode.row].Cells[lastNode.col].Style.BackColor = treasureNodeColor;

                // reset color (clear previous path checking)
                for (int i = 0; i < trace.Count; i++)
                {
                    int currentRow = trace[i].row;
                    int currentCol = trace[i].col;
                    if (this.dataGridView1.Rows[currentRow].Cells[currentCol].Style.BackColor == treasureNodeColor)
                    {
                        // do nothing
                    }
                    else
                    {
                        this.dataGridView1.Rows[currentRow].Cells[currentCol].Style.BackColor = Color.White;
                    }
                }
            }

            /*
            // Start coloring process
            for (int i = 0; i < PointSequence.GetLength(0); i++)
            {
                if (i != 0)
                {
                    // Mark nodes already checked
                    int prevRow = PointSequence[i - 1, 0];
                    int prevCol = PointSequence[i - 1, 1];
                    this.dataGridView1.Rows[prevRow].Cells[prevCol].Style.BackColor = alreadyCheckedColor;
                }

                // Mark nodes being checked
                int row = PointSequence[i, 0];
                int col = PointSequence[i, 1];
                this.dataGridView1.Rows[row].Cells[col].Style.BackColor = beingCheckedColor;
                await Task.Delay(pauseTime);
            }

            // Mark last node as checked
            int lastRow = PointSequence[PointSequence.GetLength(0) - 1, 0];
            int lastCol = PointSequence[PointSequence.GetLength(0) - 1, 1];
            this.dataGridView1.Rows[lastRow].Cells[lastCol].Style.BackColor = alreadyCheckedColor;
             
             */


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            handleSearchButton();
        }

        private async Task handleSearchButton()
        {
            SearchType option;
            if (this.fileInputGUI.useBFS)
            {
                option = SearchType.BFS;
            }
            else
            {
                option = SearchType.DFS;
            }

            // timer on
            (List<Node> route, int countNodes) = this.treasureHunt.StartHunting(option, this.fileInputGUI.includeTSP, this.fileInputGUI.showSteps);
            // timer off

            if (this.fileInputGUI.showSteps)
            {
                await show_progress();
            }


            // Show solution
            show_solution(route);

            // Write nodes, stpes, execution time to the screen
            this.lbl_nodes.Text = "Nodes " + countNodes.ToString();
            this.lbl_steps.Text = "Steps: " + route.Count.ToString();
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
