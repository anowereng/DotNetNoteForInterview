using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccess da  =  new SqlDataAccess();
            Console.WriteLine(da.GetConnectionString());
            da.LoadData("Select * from employee");
            da.SaveData("Insert into employees values('anower','23434','Male')");

            DataAccess da2 = new SqliteDataAccess();
            Console.WriteLine(da2.GetConnectionString());
            da2.LoadData("Select * from Company");
            da2.SaveData("Insert into Company values('anower','23434','Male')");
        }
    }
}
