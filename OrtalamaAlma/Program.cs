using System;

namespace OrtalamaAlma
{
    class Program
    {
        static void Main(string[] args)
        {
        inputPoint:
            Console.WriteLine("Please Enter a Number");
            string input = Console.ReadLine();
            int givenNumber = 0;
            try
            {
                givenNumber = Convert.ToInt32(input);
                if (givenNumber<0)
                {
                    goto inputPoint;
                }
                Console.WriteLine("Number : {0}",givenNumber);
            }
            catch (Exception)
            {

                goto inputPoint;
            }
            int result = ReturnFibonacci(givenNumber);
            Console.WriteLine("Result : {0}",result);
            int ReturnFibonacci(int givenNumber)
            {
                //if (givenNumber==0)
                //{
                //    return 0;
                //}
                //else if (givenNumber==1)
                //{
                //    return 1;
                //}
                //else
                //{
                //    return ReturnFibonacci(givenNumber - 1) + ReturnFibonacci(givenNumber - 2);
                //}
                int result;
                result = givenNumber==0 ? 0 : givenNumber==1 ? 1 : ReturnFibonacci(givenNumber - 1) + ReturnFibonacci(givenNumber - 2);
                return result;
            }
        }
        
    }
}
