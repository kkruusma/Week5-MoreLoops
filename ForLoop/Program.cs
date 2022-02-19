using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will not skateboard in the hall
            //string message = "I will not skateboard in the hall.".ToUpper();

            for(int i = 0; i < 10; i++) //start (int i = 0), end (i < 10), step (i++)
            {
                Console.WriteLine($"{i+1}. I will not skateboard in the hall.".ToUpper());
            }

        }
    }
}
