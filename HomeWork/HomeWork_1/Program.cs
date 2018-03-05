using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1.Список всех процессов");
            Console.WriteLine("2.Выбрать процесс по PID");
            Console.WriteLine("3.Запустить процесс");
            Console.WriteLine("4.Оставить процесс");
            Console.WriteLine("5.Показать информацию о потоках");
            Console.WriteLine("6.Показать информацию о модулях");
            var input = Int32.Parse(Console.ReadLine());


            var processes = new ProcessManager();

            if (input > 0 && input <= 6)
            {
                switch (input)
                {
                    case 1:
                        {
                            var collection = processes.GetAllProcesses();
                            foreach (var item in collection)
                            {
                                Console.WriteLine(String.Format($"ID: {item.Id} Name: {item.ProcessName}"));
                            }
                        }; break;
                    case 2:
                        {
                            Console.WriteLine("Введите ID:");
                            var inputID = Int32.Parse(Console.ReadLine());
                            Console.WriteLine($"Имя процесса: {processes.GetProcess(inputID).ProcessName}");
                        }; break;
                    case 3:
                        {
                            Console.WriteLine("Введите имя процесса:");
                            var name = Console.ReadLine();
                            if (!String.IsNullOrEmpty(name))
                            {
                                var process = processes.StartProcess(name);
                                Console.WriteLine($"ID процесса: {process.Id}");
                            }
                        }; break;
                    case 4:
                        {
                            Console.WriteLine("Введите имя процесса:");
                            var name = Console.ReadLine();
                            if(!String.IsNullOrEmpty(name))
                                processes.CloseProcess(name);
                        }; break;
                    case 5:
                        {
                            Console.WriteLine("Введите имя процесса:");
                            var name = Console.ReadLine();
                            if (!String.IsNullOrEmpty(name))
                            {
                                var collection = processes.GetModules(name);
                                foreach (ProcessModule item in collection)
                                {
                                    Console.WriteLine(String.Format($"Name: {item.ModuleName}  MemorySize: {item.ModuleMemorySize}"));
                                }
                            }
                        }; break;
                    case 6:
                        {
                            Console.WriteLine("Введите имя процесса:");
                            var name = Console.ReadLine();
                            if (!String.IsNullOrEmpty(name))
                            {
                                var collection = processes.GetThreads(name);
                                foreach (ProcessThread item in collection)
                                {
                                    Console.WriteLine(String.Format($"ID: {item.Id}  State: {item.ThreadState}"));
                                }
                            }
                        }; break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
