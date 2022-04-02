using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifeTime
{
    public interface ICounter
    {
        int Get();
        void Increment();
    }
}
