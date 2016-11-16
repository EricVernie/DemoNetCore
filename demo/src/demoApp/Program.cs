using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            demoLib.ClassCore client=new demoLib.ClassCore();
            string name=client.GetName();
            Console.WriteLine(name);
        }
    }
}
