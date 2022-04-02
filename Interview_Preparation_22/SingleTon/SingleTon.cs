using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTonExample
{
    public sealed class SingleTon
    {
        private SingleTon() { }
        private static SingleTon _instance;

        public static SingleTon GetInStance()
        {
            if (_instance == null)
                _instance = new SingleTon();

            return _instance;
        }

        public static void SomMethod()
        {
            // code
        }
    }
}
