using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal class ArrayConverter
    {
        public List<T> ArrayTolist<T>(params T[] datas)
        {
            var list = new List<T>();
            foreach (var item in datas)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
