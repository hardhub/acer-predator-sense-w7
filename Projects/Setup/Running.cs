using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using BOOTSTRAPTOR;


namespace Setup
{
    internal class Running
    {
        public void Go(string[] args)
        {
            Assembly assembly = this.GetAssembly();

            // Setup
            Type setup = assembly.GetType("BOOTSTRAPTOR.Setup");

            // Version
            FieldInfo field = setup.GetField("gOSversion", BindingFlags.Static | BindingFlags.NonPublic);
            Console.WriteLine($"Current version: {field.GetValue(null)}");

            field.SetValue(null, "6.1");
            Console.WriteLine($"Updated version: {field.GetValue(null)}");

            // Main
            MethodInfo main = setup.GetMethod("Main");
            main.Invoke(null, new object[] { args });
        }

        private Assembly GetAssembly()
        {
            return typeof(Messages).Assembly;
        }
    }
}
