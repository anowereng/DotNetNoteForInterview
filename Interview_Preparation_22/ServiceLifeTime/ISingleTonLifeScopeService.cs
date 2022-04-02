using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLifeTime
{
    public interface ISingleTonLifeScopeService
    {
        string GetMessage();
        int IncrementAndGet();
    }
}
