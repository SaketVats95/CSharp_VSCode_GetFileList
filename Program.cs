using System;
using System.IO;

namespace C_Sharp_GetAll_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Saket\Desktop\C_Sharp_GetAll_Files";
            DirectoryInfo d = new DirectoryInfo(path);
            foreach (var i in d.GetFiles()) { Console.WriteLine(i.FullName + "\n"); }
            Console.WriteLine("Hello World!");
        }
    }
}
