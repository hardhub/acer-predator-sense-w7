using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Setup
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Running running = new Running();
            running.Go(args);
        }
    }
}
