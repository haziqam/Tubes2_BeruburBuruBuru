using System;
using System.Collections.Generic;
// using System.IO.File;
using System.Linq;
using System.Text;

/* Adapted Treasure hunt for new data structure, using same algorithm as previous model */
/* New data structure used for better modularity and data encapsulation */

namespace src
{
    public class InvalidInputSymbolException : Exception
    {
        public InvalidInputSymbolException(int row, int col)
            : base("Invalid input symbol at line " + row + ", column " + col)
        {
        }

        public InvalidInputSymbolException(int row)
            : base("Invalid input symbol at line " + row)
        {
        }
    }

    public class InvalidStartSymbolException : Exception
    {
        public InvalidStartSymbolException(int row, int col)
            : base("Duplicate start symbol exists at line " + row + ", column " + col)
        {
        }
        
        public InvalidStartSymbolException()
            : base("No start symbol found!")
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
        // public static const HashSet<char> Symbols = {START, TREASURE, PATH, BLOCK};
        public const char START = 'K';
        public const char TREASURE = 'T';
        public const char PATH = 'R';
        public const char BLOCK = 'X';
    }

    static class Directions
    {
        public const char UP = 'U';
        public const char RIGHT = 'R';
        public const char DOWN = 'D';
        public const char LEFT = 'L';
        public const char STARTDUMMY = 'S';
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
        
        public Node(Position position, char choice, Node? parent = null) {
            this.position = position;
            this.choice = choice;
            this.parent = parent;
        }
    }

    public class TreasureHunt
    {
        private readonly Peta Map;

        public TreasureHunt(string filePath)
        {
            string[,] matrix = ReadMatrixFromFile(filePath);
            Map = new Peta(matrix);
        }

        /* Getters & setters */
        public char this[int row, int col] => Map[row, col];

        public int Row => Map.nRow;
        public int Col => Map.nCol;

        private string[,] ReadMatrixFromFile(string filePath) {
            // read all lines from file
            string[] lines = System.IO.File.ReadAllLines(filePath);

            // get the (supposedly valid) dimension of map matrix
            int rows = lines.Length;
            int cols = lines[0].Split(' ').Length;
            
            // create the matrix
            string[,] matrix = new string[rows, cols];

            // populate the matrix with values from the file
            for (int i = 0; i < rows; i++) {
                string[] splitLine = lines[i].Split(' ');
                for (int j = 0; j < cols; j++) {
                    // throw invalid if a line doesn't match the number of char with first line
                    if(splitLine.Length != cols) throw new InvalidInputSymbolException(i+1);

                    // throw invalid if not spaced correctly
                    if(splitLine[j].Length != 1) throw new InvalidInputSymbolException(i+1, j+1);
                    matrix[i, j] = splitLine[j];
                }
            }
            return matrix;
        }

        public void displayMap(){
            for (int i = 0; i < Map.nRow; i++) {
                for (int j = 0; j < Map.nCol; j++) {
                    Console.Write(Map[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /* Path finding of all treasures with BFS, TSP toggle by default set to false,
            returns list of directions (final route) and number of searches  done */
        public (List<Node>, int) StartHunting(SearchType mode, bool TSP = false)
        {
            Position oldStart = Map.startPos;   // used for TSP toggle to return to initial starting position
            Peta searchMap = new Peta(Map);     // create new map for marking

            List<Node> path = new List<Node>();
            int searchCount = 0;
            // every treasure MUST BE connected to starting position, otherwise throw exception
            if(mode == SearchType.BFS)
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
                if(mode == SearchType.BFS)
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

            return (path, searchCount);
        }

        private (List<Node>, int) BFS(Peta searchMap)
        {
            // initialize starting state
            PetaVisit isVisited = new PetaVisit(Map.nRow, Map.nCol);

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
                Position temp;
                if (searchMap.isUpValid(currPos))
                {
                    // check if grid has not been traversed before during this search
                    temp = currPos.up();
                    if (!isVisited[temp.row,temp.col]) memo.Enqueue(new Node(temp, Directions.UP, currNode));
                }
                // check if going right is valid
                if (searchMap.isRightValid(currPos))
                {
                    temp = currPos.right();
                    if (!isVisited[temp.row,temp.col]) memo.Enqueue(new Node(temp, Directions.RIGHT, currNode));
                }
                // check if going down is valid
                if (searchMap.isDownValid(currPos))
                {
                    temp = currPos.down();
                    if (!isVisited[temp.row,temp.col]) memo.Enqueue(new Node(temp, Directions.DOWN, currNode));
                }
                // check if going left is valid
                if (searchMap.isLeftValid(currPos))
                {
                    temp = currPos.left();
                    if (!isVisited[temp.row,temp.col]) memo.Enqueue(new Node(temp, Directions.LEFT, currNode));
                }

            } while(!searchMap.isTreasure(currPos) && (memo.Count != 0));

            if (searchMap.isTreasure(currPos))
            {
                // set current position as new starting point for next BFS
                searchMap.setStart(currPos);

                // return list and searchcount
                List<Node> path = new List<Node>();
                while (currNode.choice != Directions.STARTDUMMY && currNode.parent != null) {
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

        private (List<Node>, int) DFS(Peta searchMap)
        {
            // initialize starting state
            PetaVisit isVisited = new PetaVisit(Map.nRow, Map.nCol);

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
                Position temp;
                if (searchMap.isUpValid(currPos))
                {
                    // check if grid has not been traversed before during this search
                    temp = currPos.up();
                    if (!isVisited[temp.row,temp.col]) memo.Push(new Node(temp, Directions.UP, currNode));
                }
                // check if going right is valid
                if (searchMap.isRightValid(currPos))
                {
                    temp = currPos.right();
                    if (!isVisited[temp.row,temp.col]) memo.Push(new Node(temp, Directions.RIGHT, currNode));
                }
                // check if going down is valid
                if (searchMap.isDownValid(currPos))
                {
                    temp = currPos.down();
                    if (!isVisited[temp.row,temp.col]) memo.Push(new Node(temp, Directions.DOWN, currNode));
                }
                // check if going left is valid
                if (searchMap.isLeftValid(currPos))
                {
                    temp = currPos.left();
                    if (!isVisited[temp.row,temp.col]) memo.Push(new Node(temp, Directions.LEFT, currNode));
                }

            } while(!searchMap.isTreasure(currPos) && (memo.Count != 0));

            if (searchMap.isTreasure(currPos))
            {
                // set current position as new starting point for next BFS
                searchMap.setStart(currPos);

                // return list and searchcount
                List<Node> path = new List<Node>();
                while (currNode.choice != Directions.STARTDUMMY && currNode.parent != null) {
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

