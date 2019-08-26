using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace Informer
{
    class Informer : IInformer
    {
        virtual public void DiskSpaceInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine(
                        "  Available space to current user:{0, 15} Mbytes",
                        d.AvailableFreeSpace / 1024 / 1024);

                    Console.WriteLine(
                        "  Total available space:          {0, 15} Mbytes",
                        d.TotalFreeSpace / 1024 / 1024);

                    Console.WriteLine(
                        "  Total size of drive:            {0, 15} Mbytes ",
                        d.TotalSize / 1024 / 1024);
                }
            }
        } // Информация по всем дискам
        virtual public void DiskSpaceInfo(string diskname)
        {
            DriveInfo d = new DriveInfo(diskname);

            Console.WriteLine("Drive {0}", d.Name);
            Console.WriteLine("  Drive type: {0}", d.DriveType);
            if (d.IsReady == true)
            {
                Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                Console.WriteLine("  File system: {0}", d.DriveFormat);
                Console.WriteLine(
                    "  Available space to current user:{0, 15} Mbytes",
                    d.AvailableFreeSpace / 1024 / 1024);

                Console.WriteLine(
                    "  Total available space:          {0, 15} Mbytes",
                    d.TotalFreeSpace / 1024 / 1024);

                Console.WriteLine(
                    "  Total size of drive:            {0, 15} Mbytes ",
                    d.TotalSize / 1024 / 1024);
            }
        } // Информация по заданному диску
        public void RAMSpaceInfo()
        {
            ComputerInfo ci = new ComputerInfo();
            Console.WriteLine(" Total RAM:          {0, 15} Mbytes",
                ci.TotalPhysicalMemory / 1024 / 1024);
            Console.WriteLine(" Free RAM:           {0, 15} Mbytes",
                ci.AvailablePhysicalMemory / 1024 / 1024);
        } // Информация по оператвной памяти
        public void OSInfo()
        {
            ComputerInfo ci = new ComputerInfo();
            Console.WriteLine(" OS Platform:           {0, 15} Mbytes",
                ci.OSPlatform);
            Console.WriteLine(" OS Version:            {0, 15} Mbytes",
                ci.OSVersion);
            Console.WriteLine(" InstalledUICulture:    {0, 15} Mbytes",
                ci.InstalledUICulture);
        } // Информация по ОС
        public string GetCurrentMethodName()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            return sf.GetMethod().Name;
        }
    }
    class DeliveredInformer : Informer
    {
        public override void DiskSpaceInfo()
        {
            Console.WriteLine("Вызов метода {0} в наследованном классе {1}", GetCurrentMethodName(), this.GetType().Name);
            base.DiskSpaceInfo();
        }
    }
}
    