using System;

namespace Casting
{
    public class Program
    {
        public static void Main(string[] args){
            int varX = 10;
            double varY = varX;
            
            float varX1 = 12000f;
            int varY1 = (int)varX1;

            int varY2 = varY1++;
            int varX2 = Convert.ToInt32("12345");

            Console.WriteLine($"varX = {varX}, varY = {varY}, varX1 = {varX1}, varY1 = {varY1}, varY2 = {varY2}, varX2 = {varX2}");
        }
    }
}