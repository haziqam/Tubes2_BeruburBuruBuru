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
            int height = this.dataGridView1.Columns[0].Width;
            
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
                        this.dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }
                    else if (Map[i, j] == 'K')
                    {
                        this.dataGridView1.Rows[i].Cells[j].Value = "START";
                    }
                }
            }
        }

        public void show_solution(char[,] Map)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
