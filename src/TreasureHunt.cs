using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Node {
            public int x;
            public int y;
            public int steps;
            public Node? parent;
            
            public Node(int x, int y, int steps, Node parent) {
                this.x = x;
                this.y = y;
                this.steps = steps;
                this.parent = parent;
            }
            // public Node(){
            //     this.x = -1;
            //     this.y = -1;
            //     this.steps = 0;
            //     this.parent = null;
            // }
            public bool isEqual(Node other){
                return (this.x==other.x && this.y == other.y);
            }
    }
    internal class TreasureHunt
    {

        private string[,] Map {get;}
        private List<Node> list;
        private int row;
        private int col;
        private int countTreasure;
        private int countNodeBFS;
        public TreasureHunt()
        {
            Console.WriteLine("CTORRRRR");
            Map = new string[100, 100];
            Map = ReadMatrixFromFile("../src/FILE.txt");
            list = new List<Node>();
            row = Map.GetLength(0);
            col = Map.GetLength(1);
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (Map[i, j] == "T") {
                        countTreasure++;
                        break;
                    }

                }
            }
            countNodeBFS = 0;
            // Console.WriteLine("col"+col);
            // Console.WriteLine("row"+row);
        }


        public string[,] ReadMatrixFromFile(string filePath) {
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
        public void displayMap(){
            for (int i = 0; i < Map.GetLength(0); i++) {
                for (int j = 0; j < Map.GetLength(1); j++) {
                    Console.Write(Map[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static bool IsValid(int x, int y, int n, int m) {
            return x >= 0 && x < n && y >= 0 && y < m;
        }

        public void BFS(){
            int[] dx = {0, 0, -1, 1};//Prioritas : Kiri,Kanan,Bawah,Atas
            int[] dy = {-1, 1, 0, 0};
            int startX=0;
            int startY=0;
            bool[,] visited = new bool[row,col];
            Queue<Node> queue = new Queue<Node>();
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {      
                    if (Map[i,j] == "K") {
                        startX = i;
                        startY = j;
                        break;
                    }

                }
            }
            bool startlast= false;
            queue.Enqueue(new Node(startX,startY,0, null));
            visited[startX, startY] = true;
            while (queue.Count>0){
                Node temp=queue.Dequeue();
                if (Map[temp.x,temp.y]=="T") {
                    List<Node> path = new List<Node>();
                    Map[temp.x,temp.y]="K";
                    Map[startX,startY]="R";
                    // if(list.Last()==temp){
                    //     startlast=true;
                    // }
                    while (temp != null) {
                        path.Add(temp);
                        temp = temp.parent;
                    }
                    path.Reverse();
                    foreach (var item in path)
                    {    
                        list.Add(item);   
                    }
                    for (int i=0;i<list.Count-1;i++){
                        if(list[i].isEqual(list[i+1])){
                            list.RemoveAt(i+1);
                        }
                    }
                    break;
                }
                for (int i = 0; i < 4; i++) {
                    int nx = temp.x + dx[i];
                    int ny = temp.y + dy[i];
                    
                    if (IsValid(nx, ny, row, col) && !visited[nx, ny] && Map[nx,ny] != "X") {
                        visited[nx, ny] = true;
                        queue.Enqueue(new Node(nx, ny, temp.steps + 1, temp));
                        countNodeBFS++;
                    }
                }
            }
        
        }

        public void showPath(){
            if (list == null) {
            Console.WriteLine("Treasure not found!");
            } else {
                Console.WriteLine("Treasure found in {0} steps.", list.Count - 1);
                Console.WriteLine("Path:");
                foreach (Node node in list) {
                    Console.WriteLine("({0}, {1})", node.x, node.y);
                }
                Console.WriteLine("Node : "+countNodeBFS);
            }
        }
        public void BFSMain(){
            for (int i=0;i<countTreasure;i++){
                BFS();
            }
        }

    }
}

