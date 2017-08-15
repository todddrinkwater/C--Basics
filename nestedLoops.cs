using System;

namespace csharppractice.cs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Write a program that prints the result of counting up to 24 using four different increments.First, count by 1s, then by 2s, by 3s, and finally by 4s.
            for (int i = 1; i < 5; i++){
                Console.Write($" {i} - ");
                for (int j = 1; j < 25; j++)
                {
                    int num = i * j;
                    string multiply = num.ToString();
                    Console.Write($" {multiply} ");
                }
                Console.WriteLine();
            }
        }
    }
}
