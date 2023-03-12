// See https://aka.ms/new-console-template for more information
using System;

namespace myproject
{  
    
    class Program
    {
        class TreasureHunt{
            public int[,] Map;
        
            public TreasureHunt(){
                Console.WriteLine("CTORRRRR");
                Map=new int[10,10];
            }

        }
        static void Main(string[] args)
        {
            TreasureHunt a=new TreasureHunt();
        }
    }
}