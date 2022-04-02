using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    internal class SqliteDataAccess: DataAccess
    {
        public override string GetConnectionString()
        {
            var conString = base.GetConnectionString();
             conString +=  "modified";
            return conString;
        }
        public override bool SaveData(string sql)
        {
            // sql save code
            Console.WriteLine("Save called");
            return true;
        }
        public override List<string> LoadData(string sql)
        {
            var result = new List<string>();
            // sql load code
            Console.WriteLine("Load data");
            return result;
        }
    }
}
