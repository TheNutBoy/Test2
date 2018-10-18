using System.Collections.Generic;
using log4net;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Processor> procs = new List<Processor>();
            Logger.InitLogger();
            for (int i = 0; i < 10; i++)
            {
                procs.Add(new Processor());
                procs[i].Process(i);
            }

            foreach (var proc in procs)
            {
                proc.Finish();
            }
        }
    }
}
