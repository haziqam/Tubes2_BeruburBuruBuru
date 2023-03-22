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
    public partial class VisualizeMapGUI : Form
    {
        public VisualizeMapGUI()
        {
            InitializeComponent();
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

        public void fill_map(char[,] Map)
        {
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    if (Map[i, j] == 'X')
                    {
                        this.dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                    }
                    else if (Map[i, j] == 'K')
                    {
                        this.dataGridView1.Rows[i].Cells[j].Value = "START";
                    }
                    else if (Map[i, j] == 'T')
                    {
                        this.dataGridView1.Rows[i].Cells[j].Value = "TREAUSRE";
                    }
                }
            }
        }

        public void show_solution(char[,] Map)
        {
            
        }

        public async Task show_progress(int[,] PointSequence, int pauseTime)
        {
            for (int i = 0; i < PointSequence.GetLength(0); i++)
            {
                if (i != 0)
                {
                    // Mark nodes already checked
                    int prevRow = PointSequence[i - 1, 0];
                    int prevCol = PointSequence[i - 1, 1];
                    this.dataGridView1.Rows[prevRow].Cells[prevCol].Style.BackColor = Color.Blue;
                }

                // Mark nodes being checked
                int row = PointSequence[i, 0];
                int col = PointSequence[i, 1];
                this.dataGridView1.Rows[row].Cells[col].Style.BackColor = Color.Red;
                await Task.Delay(pauseTime);
            }

            // Mark last node as checked
            int lastRow = PointSequence[PointSequence.GetLength(0) - 1, 0];
            int lastCol = PointSequence[PointSequence.GetLength(0) - 1, 1];
            this.dataGridView1.Rows[lastRow].Cells[lastCol].Style.BackColor = Color.Blue;
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int[,] PointSequence = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 1, 0 }, { 0, 3 }, { 2, 1 } };
            show_progress(PointSequence, 1000);
        }
    }
}
