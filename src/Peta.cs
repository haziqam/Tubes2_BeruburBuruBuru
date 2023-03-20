using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace src {
    class Peta
    {
        private char[,] peta;
        public readonly int nRow;
        public readonly int nCol;

        public Peta(List<List<char>> petaList)
        {
            peta = new char[petaList[0].Count, petaList.Count];
        }

        public isPosValid(Position x)
        {
            return (0 <= x.row && x.row < nRow) && (0 <= x.col && x.col < nCol);
        }

        public isUpValid(Position x)
        {
            return (0 <= x.row-1);
        }

        public isRightValid(Position x)
        {
            return (x.col+1 < nCol);
        }

        public isDownValid(Position x)
        {
            return (x.row+1 < nRow);
        }

        public isLeftValid(Position x)
        {
            return (0 <= x.col-1);
        }

        // public char this[int row, int col] => map[row, col];
        public char this[int row, int col]
        {
            get => map[row, col];
            set => map[row,col] = value;
        }
    }

    class PetaVisit
    {
        private bool[,] peta;
        private nRow;
        private nCol;

        public char this[int row, int col]
        {
            get => map[row, col];
            set => map[row,col] = value;
        }

        public void reset()
        {
            
        }
    }

    class Position
    {
        public readonly int row;
        public readonly int col;

        public Position(int _row, int _col)
        {
            row = _row;
            col = _col;
        }

        public Position up()
        {
            return new Position(row-1, col);
        }

        public Position right()
        {
            return new Position(row, col+1);
        }

        public Position down()
        {
            return new Position(row+1, col);
        }

        public Position left()
        {
            return new Position(row, col-1);
        }
    }
}