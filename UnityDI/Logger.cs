using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDI
{
    class Logger : ILogger
    {
        


        public void Write(string msg)
        {
            Console.WriteLine();
            Console.WriteLine("*** In logger ***");
            Console.WriteLine(@"message {0}", msg);
        }
    }
}
