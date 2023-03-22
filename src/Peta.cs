using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreasureHunt
{
    class Peta
    {
        private char[,] peta;
        private readonly int nRow;
        private readonly int nCol;
        public int nTreasure { get; }
        public Position startPos { get; }

        public Peta(List<List<char>> petaList)
        {
            nRow = petaList.Count;
            nCol = petaList[0].Count;

            peta = new char[nRow, nCol];
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    peta[i,j] = petaList[i][j];
                }
            }
        }

        public Peta(Peta other)
        {
            nRow = other.nRow;
            nCol = other.nCol;

            peta = new char[nRow, nCol];
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    peta[i,j] = other.peta[i,j];
                }
            }
        }

        /* Selector */
        public char this[int row, int col] => map[row, col];
        // public char this[int row, int col]
        // {
        //     get => map[row, col];
        //     set => map[row, col] = value;
        // }

        public (int, int) Size
        {
            get { return (this.nRow, this.nCol); }
        }

        /* Position checking */
        public bool isPosInBound(Position x)
        {
            return (0 <= x.row && x.row < nRow) && (0 <= x.col && x.col < nCol);
        }

        public bool isUpValid(Position x)
        {
            if (0 <= x.row-1)
            {
                return peta[x.row, x.col] != TreasureSymbols.BLOCK;
            }
            return false;

        }

        public bool isRightValid(Position x)
        {
            if (x.col+1 < nCol)
            {
                return peta[x.row, x.col] != TreasureSymbols.BLOCK;
            }
            return false;
        }

        public bool isDownValid(Position x)
        {
            if (x.row+1 < nRow)
            {
                return peta[x.row, x.col] != TreasureSymbols.BLOCK;
            }
            return false;
        }

        public bool isLeftValid(Position x)
        {
            if (0 <= x.col-1)
            {
                return peta[x.row, x.col] != TreasureSymbols.BLOCK;
            }
            return false;
        }

        public bool isTreasure(Position x)
        {
            return peta[x.row, x.col] == TreasureSymbols.TREASURE;
        }

        public void eraseTreasure(Position x)
        {
            if (peta[startPos.row, startPos.col] == TreasureSymbols.TREASURE)
            {
                nTreasure--;
                peta[startPos.row, startPos.col] = TreasureSymbols.PATH;
            }
        }

        public void setStart(Position x)
        {
            // set old starting point to regular path
            peta[startPos.row, startPos.col] = TreasureSymbols.PATH;

            // make new starting point the map's starting point
            startPos = new Position(x);

            // if replaced point is a treasure, reduce treasure
            if (peta[startPos.row, startPos.col] == TreasureSymbols.TREASURE)
            {
                nTreasure--;
            }

            peta[startPos.row, startPos.col] = TreasureSymbols.START;
        }

        public void setTreasure(Position x)
        {
            if (peta[x.row, x.col] == TreasureSymbols.START)
            {
                // do nothing, why set treasure at starting position; also breaks the code
            }
            else
            {
                peta[x.row, x.col] = TreasureSymbols.TREASURE;
                nTreasure++;
            }
        }
    }

    class PetaVisit
    {
        private bool[,] peta;
        private int nRow;
        private int nCol;

        public PetaVisit(int row, int col)
        {
            nRow = row;
            nCol = col;
            peta = new bool[nRow, nCol];
            resetVisit();
        }

        // public PetaVisit((int row, int col) size)
        // {
        //     nRow = size.row;
        //     nCol = size.col;
        //     peta = new bool[nRow, nCol];
        // }
        
        /* Selector */
        public bool this[int row, int col] => map[row, col];

        public void visit(Position x)
        {
            peta[x.row, x.col] = true;
        }

        public void resetVisit()
        {
            for(int i = 0; i < nRow; i++)
            {
                for(int j = 0; j < nCol; j++)
                {
                    peta[i,j] = false;
                }
            }
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

        public Position(Position other)
        {
            row = other.row;
            col = other.col;
        }

        public (int, int) coord
        {
            get { return (this.row, this.col); }
        }

        public bool isEqual(Position other)
        {
            return (this.row == other.row) && (this.col == other.col);
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