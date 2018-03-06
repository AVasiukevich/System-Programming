using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = new List<double>();
            var R = new List<double>();
            var locker1 = new object();
            var locker2 = new object();


            var A = new Thread(() =>
            {
                var i = 1;
                while (true)
                    lock (locker1)
                        S.Add(i++); 
            });

            A.Start();

            var B = new Thread(() =>
            {
                while (true)
                    lock (locker1)
                    {
                        Thread.Sleep(1000);
                        lock (locker2)
                        {
                            Thread.Sleep(1000);
                            R.Add(Math.Pow(S.Last(), 2));
                        }
                    }
            });

            B.Start();

            var C = new Thread(() =>
            {
                while (true)
                    if (S.Count == 0)
                        Thread.Sleep(1000);
                    else
                        lock (locker2)
                            lock (locker1)
                                R.Add(S.Last() / 3); 
                });

            C.Start();

            var D = new Thread(() =>
            {
                while (true)
                {
                    if (R.Count == 0)
                    { Console.WriteLine("List R empty!"); Thread.Sleep(1000); }
                    else
                        lock (locker2)
                            Console.WriteLine(R.Last());
                }
                });

            D.Start();

        }
    }
}
