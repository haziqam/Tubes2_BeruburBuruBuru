using System;
using System.Collections.Generic;

namespace src
{
    class Peta
    {
        private char[,] peta;
        public readonly int nRow;
        public readonly int nCol;
        public int nTreasure { get; private set; }
        public Position startPos { get; private set; }

        /* matrix must contain single character string only */
        public Peta(string[,] matrix)
        {
            nRow = matrix.GetLength(0);
            nCol = matrix.GetLength(1);
            nTreasure = 0;
            
            bool noStartSymbol = true;
            peta = new char[nRow, nCol];
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    char inputSymbol = matrix[i,j][0];

                    if(inputSymbol == TreasureSymbols.START)
                    {
                        if(noStartSymbol)
                        {
                            startPos = new Position(i,j);
                            noStartSymbol = false;
                        }
                        else throw new InvalidStartSymbolException(i+1, j+1);   // no two starting point can exists
                    }
                    else if(inputSymbol == TreasureSymbols.TREASURE)
                    {
                        nTreasure++;
                    }
                    else if(inputSymbol != TreasureSymbols.PATH && inputSymbol != TreasureSymbols.BLOCK)
                    {
                        // input symbol != start, treasure, path, or even block
                        throw new InvalidInputSymbolException(i+1, j+1);
                    }

                    // insert char into map
                    peta[i,j] = matrix[i,j][0];
                }
            }

            if(noStartSymbol) throw new InvalidStartSymbolException();
        }

        public Peta(Peta other)
        {
            nRow = other.nRow;
            nCol = other.nCol;
            nTreasure = other.nTreasure;
            startPos = other.startPos;

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
        public char this[int row, int col] => peta[row, col];
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
            int newRow = x.row-1;
            if (0 <= newRow)
            {
                return peta[newRow, x.col] != TreasureSymbols.BLOCK;
            }
            return false;

        }

        public bool isRightValid(Position x)
        {
            int newCol = x.col+1;
            if (newCol < nCol)
            {
                return peta[x.row, newCol] != TreasureSymbols.BLOCK;
            }
            return false;
        }

        public bool isDownValid(Position x)
        {
            int newRow = x.row+1;
            if (newRow < nRow)
            {
                return peta[newRow, x.col] != TreasureSymbols.BLOCK;
            }
            return false;
        }

        public bool isLeftValid(Position x)
        {
            int newCol = x.col-1;
            if (0 <= newCol)
            {
                return peta[x.row, newCol] != TreasureSymbols.BLOCK;
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
        public bool this[int row, int col] => peta[row, col];

        public void visit(Position x)
        {
            peta[x.row, x.col] = true;
        }

        /* tryVisit simulates checking and visiting the map, if it is visited before, returns true.
            Otherwise, returns that it is not visited before, then sets the position to true */
        // basically TestAndSet
        public bool tryVisit(Position x)
        {
            bool visited = peta[x.row, x.col];
            peta[x.row, x.col] = true;
            return visited;
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