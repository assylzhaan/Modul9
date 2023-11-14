using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9PR
{
    class Program
    {
        static void Main()
        {
            Storage[] storageDevices = new Storage[3];

            storageDevices[0] = new Flash { Name = "Flash1", Model = "123", USB_Speed = 100, MemorySize = 64 };
            storageDevices[1] = new DVD { Name = "DVD1", Model = "456", ReadWriteSpeed = 8, DoubleSided = false, Capacity = 4.7 };
            storageDevices[2] = new HDD { Name = "HDD1", Model = "789", USB_Speed = 50, Partitions = 2, PartitionSize = 500 };

            Console.WriteLine("Information about storage devices:");
            foreach (var device in storageDevices)
            {
                device.DisplayInfo();
                Console.WriteLine($"Total Memory: {device.GetMemory()} GB, Free Memory: {device.GetFreeMemory()} GB\n");
            }

            double totalMemory = 0;
            foreach (var device in storageDevices)
            {
                totalMemory += device.GetMemory();
            }
            Console.WriteLine($"Total Memory of all devices: {totalMemory} GB");


            double dataSizeToCopy = 565;
            Console.WriteLine($"\nCopying data of size {dataSizeToCopy} GB to all devices:");
            foreach (var device in storageDevices)
            {
                device.CopyData(dataSizeToCopy);
            }

            double dataTransferSpeed = 20;

            Console.ReadKey();

        }
    }
}
