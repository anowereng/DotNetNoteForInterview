using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLifeTime
{
    public class SingleTonLifeScopeService: ISingleTonLifeScopeService
    {
        private readonly ICounter counter;
        public string GetMessage()
        {
            return "How are you my friend? SingleTon";
        }
        public SingleTonLifeScopeService(ICounter counter)
        {
            this.counter = counter;
        }

        public int IncrementAndGet()
        {
            counter.Increment();
            return counter.Get();
        }
    }
}
