namespace Informer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informer inf1 = new Informer();
            //inf1.DiskSpaceInfo("D:\\");
            //inf1.OSInfo();
            DeliveredInformer inf2 = new DeliveredInformer();
            inf2.DiskSpaceInfo();
        }
    }
}
