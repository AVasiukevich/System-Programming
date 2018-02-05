using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    public class ProcessManager
    {
        private Process[] processes;

        public ProcessManager()
        {
            processes = processes = Process.GetProcesses(".");
        }
        public Process[] GetAllProcesses()
        {
            return processes;
        }
        public Process GetProcess(int id)
        {
            return processes.FirstOrDefault(pro => pro.Id == id);
        }
        public Process StartProcess(string fileName)
        {
            return Process.Start(fileName);
        }
        public void CloseProcess(string nameProcess)
        {
            Process.GetProcessesByName(nameProcess)[0].Close();
        }
        public ProcessModuleCollection GetModules(string nameProcess)
        {
            return Process.GetProcessesByName(nameProcess)[0].Modules;
        }
        public ProcessThreadCollection GetThreads(string nameProcess)
        {
            return Process.GetProcessesByName(nameProcess)[0].Threads;
        }
    }
}
