using System;

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
}