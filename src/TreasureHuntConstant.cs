using System;

namespace src
{
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
    
}