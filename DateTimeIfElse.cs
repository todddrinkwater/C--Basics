using System;

namespace DateTimeIfElse.cs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            int currentHour = currentTime.Hour;
            if(currentHour < 12){
                Console.WriteLine("Good Morning!");
            }
			else if (currentHour < 17)
			{
				Console.WriteLine("Good Afternoon!");
			}
			else if (currentHour < 22)
			{
				Console.WriteLine("Good Evening!");
			}
            else {
                Console.WriteLine("Good Night!");
            }        
        }
    }
}
