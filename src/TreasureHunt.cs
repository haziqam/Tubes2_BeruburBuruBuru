using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Adapted Treasure hunt for new data structure, using same algorithm as previous model */
/* New data structure used for better modularity and data encapsulation */

namespace TreasureHunt
{
    public class InvalidInputSymbolException : Exception
    {
        public InvalidInputSymbolException(int row, int col)
            : base("Invalid input symbol at line " + row + ", column " + col)
        {
        }
    }

    public class TreasureNotConnectedException : Exception
    {
        public TreasureNotConnectedException()
            : base("Treasure is not connected to starting point!")
        {
        }
    }

    static class TreasureSymbols
    {
        public static const HashSet<char> Symbols = {START, TREASURE, PATH, BLOCK};
        public static const char START = 'K';
        public static const char TREASURE = 'T';
        public static const char PATH = 'R';
        public static const char BLOCK = 'X';
    }

    static class Directions
    {
        public static const char UP = 'U';
        public static const char RIGHT = 'R';
        public static const char DOWN = 'D';
        public static const char LEFT = 'L';
        public static const char STARTDUMMY = 'S';
    }

    enum SearchType
    {
        BFS,
        DFS
    }

    class Node
    {
        public readonly Position position;
        public readonly char choice;
        public readonly Node? parent;
        
        public Node(Position position, char choice, Node parent = null) {
            this.position = position;
            this.choice = choice;
            this.parent = parent;
        }
    }

    internal class TreasureHunt
    {
        private readonly Peta Map;
        private 

        public TreasureHunt()
        {
            Console.WriteLine("CTORRRRR");
            Map = new char[100,100]; 
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
        }   

        private string[,] ReadMatrixFromFile(string filePath) {
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

        /* Path finding of all treasures with BFS, TSP toggle by default set to false,
            returns list of directions (final route) and number of searches  done */
        public (List<Node>, int) TreasureHunt(SearchType mode, bool TSP = false)
        {
            Position oldStart = Map.startPos;   // used for TSP toggle to return to initial starting position
            Peta searchMap = new Peta(Map);     // create new map for marking

            List<Node> path = new List<Node>();
            int searchCount = 0;
            // every treasure MUST BE connected to starting position, otherwise throw exception
            if(mode = SearchType.BFS)
            {
                while (searchMap.nTreasure > 0)
                {
                    List<Node> addPath;
                    int addCount;
                    (addPath, addCount) = BFS(searchMap);
                    path.AddRange(addPath);
                    searchCount += addCount;
                }
            }
            else    // type is DFS
            {
                while (searchMap.nTreasure > 0)
                {
                    List<Node> addPath;
                    int addCount;
                    (addPath, addCount) = DFS(searchMap);
                    path.AddRange(addPath);
                    searchCount += addCount;
                } 
            }

            if (TSP)
            {
                searchMap.setTreasure(oldStart);
                if(mode = SearchType.BFS)
                {
                    List<Node> addPath;
                    int addCount;
                    (addPath, addCount) = BFS(searchMap);
                    path.AddRange(addPath);
                    searchCount += addCount;
                }
                else    // type is DFS
                {
                    List<Node> addPath;
                    int addCount;
                    (addPath, addCount) = DFS(searchMap);
                    path.AddRange(addPath);
                    searchCount += addCount;
                }

            }

            return (path, SearchCount);
        }

        private (List<Node>, int) BFS(Peta searchMap)
        {
            // initialize starting state
            PetaVisit isVisited = new PetaVisit(Map.Size);

            // initialize search count to -1 (exluding initial element of dummy node)
            int searchCount = -1;
            // initialize BFS Queue
            Queue<Node> memo = new Queue<Node>();

            // enqueue dummy initial search (starting position)
            memo.Enqueue(new Node(searchMap.startPos, Directions.STARTDUMMY));
            Node currNode;
            Position currPos;
            do
            {
                searchCount++;
                currNode = memo.Dequeue();
                currPos = currNode.position;

                isVisited.visit(currPos);
                
                /* A good alternative for path decision making from previous version
                int[] dx = {0, 0, -1, 1};   //Prioritas : Kiri,Kanan,Bawah,Atas
                int[] dy = {-1, 1, 0, 0};
                for (int i = 0; i < 4; i++) {
                    int nx = temp.x + dx[i];
                    int ny = temp.y + dy[i];
                }
                however not used in current version due to current architecture & DS */

                // checking priority: up, right, down, left (clockwise direction)
                // check if going up is valid
                if (searchMap.isUpValid(currPos))
                {
                    // check if grid has not been traversed before during this search
                    if (!isVisited[currPos.coord]) memo.Enqueue(new Node(currPos.up(), Directions.UP, currNode));
                }
                // check if going right is valid
                if (searchMap.isRightValid(currPos))
                {
                    if (!isVisited[currPos.coord]) memo.Enqueue(new Node(currPos.right(), Directions.RIGHT, currNode));
                }
                // check if going down is valid
                if (searchMap.isDownValid(currPos))
                {
                    if (!isVisited[currPos.coord]) memo.Enqueue(new Node(currPos.down(), Directions.DOWN, currNode));
                }
                // check if going left is valid
                if (searchMap.isLeftValid(currPos))
                {
                    if (!isVisited[currPos.coord]) memo.Enqueue(new Node(currPos.left(), Directions.LEFT, currNode));
                }

            } while(!searchMap.isTreasure(currPos) && (memo.Count != 0));

            if (searchMap.isTreasure(currPos))
            {
                // set current position as new starting point for next BFS
                searchMap.setStart(currPos);

                // return list and searchcount
                List<Node> path = new List<Node>();
                while (currNode.choice != Directions.STARTDUMMY) {
                    path.Add(currNode);
                    currNode = currNode.parent;
                }
                path.Reverse();

                return (path, searchCount);
            }
            else
            {
                throw new TreasureNotConnectedException();
            }
        }

        private void DFS()
        {
            // initialize starting state
            PetaVisit isVisited = new PetaVisit(Map.Size);

            // initialize search count to -1 (exluding initial element of dummy node)
            int searchCount = -1;
            // initialize DFS Stack
            Stack<Node> memo = new Stack<Node>();

            // push dummy initial search (starting position)
            memo.Push(new Node(searchMap.startPos, Directions.STARTDUMMY));
            Node currNode;
            Position currPos;
            do
            {
                searchCount++;
                currNode = memo.Pop();
                currPos = currNode.position;

                isVisited.visit(currPos);

                // checking priority: up, right, down, left (clockwise direction)
                // check if going up is valid
                if (searchMap.isUpValid(currPos))
                {
                    // check if grid has not been traversed before during this search
                    if (!isVisited[currPos.coord]) memo.Push(new Node(currPos.up(), Directions.UP, currNode));
                }
                // check if going right is valid
                if (searchMap.isRightValid(currPos))
                {
                    if (!isVisited[currPos.coord]) memo.Push(new Node(currPos.right(), Directions.RIGHT, currNode));
                }
                // check if going down is valid
                if (searchMap.isDownValid(currPos))
                {
                    if (!isVisited[currPos.coord]) memo.Push(new Node(currPos.down(), Directions.DOWN, currNode));
                }
                // check if going left is valid
                if (searchMap.isLeftValid(currPos))
                {
                    if (!isVisited[currPos.coord]) memo.Push(new Node(currPos.left(), Directions.LEFT, currNode));
                }

            } while(!searchMap.isTreasure(currPos) && (memo.Count != 0));

            if (searchMap.isTreasure(currPos))
            {
                // set current position as new starting point for next BFS
                searchMap.setStart(currPos);

                // return list and searchcount
                List<Node> path = new List<Node>();
                while (currNode.choice != Directions.STARTDUMMY) {
                    path.Add(currNode);
                    currNode = currNode.parent;
                }
                path.Reverse();

                return (path, searchCount);
            }
            else
            {
                throw new TreasureNotConnectedException();
            }
        }
    }
}

