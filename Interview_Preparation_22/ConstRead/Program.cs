using System;

namespace ConstRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(Settings.Company2);
            Console.WriteLine(Settings.Company);

        }
    }

    public class Settings
    {
        public const string Company = "Sad Musa Group"; // must be assign initialize time
        public static readonly string Company2 = "Hello"; // static can be use , const implicitly static not need
        public  readonly string Company3; // can be assign run time 
        public Settings()
        {
            this.Company3  = "asdasd";
        }

    }
}
