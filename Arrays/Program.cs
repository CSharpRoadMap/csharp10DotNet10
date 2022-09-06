using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program {
        static void Main(string[] args) {
            int [,] rectangolarArray = new int[5,5];
            int aSum = 0;

            for (int row = 0; row < 5; row++) {
                for (int column = 0; column < 5; column++) {
                    aSum++;
                    rectangolarArray[row,column] = (column == 0) ? 0 : aSum;
                }
            }

            for (int row = 0; row < 5; row++) {
                for (int column = 0; column < 5; column++) {
                    Console.Write($"{rectangolarArray[row, column]}\t");
                }
                Console.Write("\n");
            }
        }
    }
}