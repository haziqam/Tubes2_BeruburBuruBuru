using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    internal class TreasureHunt
    {
        private int[,] Map;

        public TreasureHunt()
        {
            Console.WriteLine("CTORRRRR");
            Map = new int[10, 10];
        }

        // public BFS()

        // public DFS

         public static string[,] ReadMatrixFromFile(string filePath) {
            // read all lines from file
            string[] lines = File.ReadAllLines(filePath);

            // calculate matrix dimensions
            int rows = lines.Length;
            int cols = lines[0].Split(' ').Length-1;
            // Console.WriteLine(cols);
            // Console.WriteLine(rows);
            // create the matrix
            string[,] matrix = new string[rows, cols];

            // populate the matrix with values from the file
            for (int i = 0; i < rows; i++) {
                string[] rowValues = lines[i].Split(' ');
                for (int j = 0; j < cols; j++) {
                    matrix[i, j] = rowValues[j];
                }
            }

            return matrix;
        }
    }
}
