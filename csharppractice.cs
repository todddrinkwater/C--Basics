using System;

namespace csharppractice.cs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var randomNumber = new Random().Next(3) + 1;
            Console.WriteLine("What number am I guessing between one and three?");
            var answer = int.Parse(Console.ReadLine());
            if (answer == randomNumber) Console.WriteLine("Correct");
            else Console.WriteLine($"Incorrect, it was {randomNumber}");
        }
    }
}
