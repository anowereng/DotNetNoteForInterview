using System;
using System.Collections.Generic;
using System.Text;

namespace Struct
{
    public struct StructExample
    {
        //public StructExample() // without parameter initianlized compiler error
        //{

        //}
        public string Name { get; set; }
        public string GetName()
        {
            return Name = "anower";
        }

    }
}
