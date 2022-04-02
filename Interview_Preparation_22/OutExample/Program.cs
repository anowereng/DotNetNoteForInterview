using System;

namespace OutExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int convertOutut;
            bool iSconvertSuccess  =  ParseStringToInt("asdasd", out convertOutut);
            Console.WriteLine(iSconvertSuccess);    
            Console.WriteLine(convertOutut);

        }

        public static bool ParseStringToInt(string input , out int result)
        {
            try
            {
                result =  Int32.Parse(input);
                return true;
            }
            catch 
            {
                result = 0;
                return false;
            }
        }
    }
}
