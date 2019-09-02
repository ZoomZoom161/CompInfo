using System;
namespace Informer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informer inf1 = new Informer();
            //inf1.DiskSpaceInfo("D:\\");
            //inf1.OSInfo();
            var inf2 = new Informer();
            inf2.DiskSpaceInfo();
            inf2.OSInfo();
            Console.ReadLine();
        }
    }
}
