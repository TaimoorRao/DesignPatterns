using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTon obj1 = SingleTon.MyObject();
            obj1.Method();
            Console.ReadLine();
        }
    }
    class SingleTon
    {
        private SingleTon(){ }
        public static SingleTon getInstance = null;
        private static readonly object syncThread = new object();
        public static SingleTon MyObject()
        {
            if (getInstance == null)
            {
                lock (syncThread)
                    if (getInstance == null)
                        return new SingleTon();
            }
            return getInstance;
        }
        public void Method()
        {
            Console.WriteLine("This is my method");
        }
    }
}
