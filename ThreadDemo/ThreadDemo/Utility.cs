using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    public delegate void ProcessRrporter(int percentComplete);

    public class Utility
    {
        public static void Match(ProcessRrporter p)
        {
            if (p != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    p(i * 10);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}