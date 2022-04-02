using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifeTime
{
    public class Counter : ICounter
    {
        private int count;

        public void Increment() => count++;

        public int Get() => count;
    }
}
