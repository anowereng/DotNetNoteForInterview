using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class DataAccess
    {
        public virtual string GetConnectionString()
        {
            Console.WriteLine("Connection string called");
            return "Connection string";
        }
        public abstract bool SaveData(string sql);
        public abstract List<string> LoadData(string sql);
    }
}
