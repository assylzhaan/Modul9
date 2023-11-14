using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9PR
{
  
    class HDD : Storage
    {
      
        private double usbSpeed;
        private int partitions;
        private double partitionSize;

        public double USB_Speed
        {
            get { return usbSpeed; }
            set { usbSpeed = value; }
        }

        public int Partitions
        {
            get { return partitions; }
            set { partitions = value; }
        }

        public double PartitionSize
        {
            get { return partitionSize; }
            set { partitionSize = value; }
        }


        public override double GetMemory()
        {
            return partitions * partitionSize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to HDD. Size: {dataSize} GB");
        }

        public override double GetFreeMemory()
        {
            return partitions * partitionSize * 0.95;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"HDD: {Name}, Model: {Model}, USB Speed: {usbSpeed} MB/s, Partitions: {partitions}, Partition Size: {partitionSize} GB");
        }
    }
}
