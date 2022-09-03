using System;

namespace UcgenCizme
{
    class Program
    {
        static void Main(string[] args)
        {
        inputPoint:
            Console.WriteLine("Please Enter a Positive Number");
            string input = Console.ReadLine();
            int givenNumber = 0;
            try
            {
                givenNumber = Convert.ToInt32(input);
                if (givenNumber == 0)
                {
                    goto inputPoint;
                }
            }
            catch (Exception)
            {

                goto inputPoint;
            }
            DrawTriangle(givenNumber);

            void DrawTriangle(int input) 
            {
                for (int i = 0; i < input; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            void DrawSquare(int input) 
            {
                for (int i = 0; i < input; i++)
                {
                    for (int j = 0; j < input; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
