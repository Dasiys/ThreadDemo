using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 线程

            //Thread t1=new Thread(Go);
            //t1.Start();

            //Thread t2=new Thread(GoWithParam);
            //t2.Start("Message from main");

            //Console.WriteLine("Thread t2 has ended!");
            //Console.ReadKey();

            #endregion

            #region 线程信号控制器

            //var signal = new ManualResetEvent(false);

            //new Thread(() => {
            //    Console.WriteLine("Waiting for signal...");
            //    signal.WaitOne();
            //    signal.Dispose();
            //    Console.WriteLine("Got signal!");
            //}).Start();
            //Console.WriteLine("主线程第一次");
            //Thread.Sleep(2000);
            //Console.WriteLine("主线程第二次");
            //signal.Set();// 打开“信号”

            //Console.ReadKey();

            #endregion

            #region 委托定时器
            //ProcessRrporter p = WriteProcessToConsole;
            //p += WriteProcessToFile;
            //Utility.Match(p);
            //Console.WriteLine("Done");
            //Console.ReadKey();
            #endregion

            Phone6 demoPhone6=new Phone6();
            demoPhone6.PriceChanged +=Iphone6PriceChanged ;
            demoPhone6.Price = 99;
            demoPhone6.Price = 90909;
        }

        static void Go()
        {
            Console.WriteLine("Go");
        }

        static void GoWithParam(object msg)
        {
            Console.WriteLine("Go With Param!Message: " + msg);
            Thread.Sleep(1000);
        }

        static void WriteProcessToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete + "%");
        }

        static void WriteProcessToFile(int percentComplete)
        {
            System.IO.File.AppendAllText("process.txt", percentComplete + "%");
        }


        static  void Iphone6PriceChanged(object sender,PriceChangedEventArgs e)
        {
            Console.WriteLine("旧价格:{0},新价格:{1}",e.OldPrice,e.NewPrice);
            Console.ReadLine();
        }
    }
}
