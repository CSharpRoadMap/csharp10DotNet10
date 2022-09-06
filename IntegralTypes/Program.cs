using System;

namespace IntegralTypes
{
    public class Program
    {
       static void Main(string[] args)
       {
        int anInteger = 500;
        short aShort = 100;
        sbyte anSByte = -50;
        long aLong = 1_000_000;
        int anotherInteger = 0b10101010;
        ushort anUShort = 0x0A56;

        Console.WriteLine("anInteger = {0}, aShort = {1}, anSByte = {2}, aLong = {3}, anotherInteger = {4}, anUShort = {5}", anInteger, aShort, anSByte, aLong, anotherInteger, anUShort);

        Console.WriteLine($"anInteger = {anInteger}, aShort = {aShort}, anSByte = {anSByte}, aLong = {aLong}, anotherInteger = {anotherInteger}, anUShort = {anUShort}");
       } 
    }
}