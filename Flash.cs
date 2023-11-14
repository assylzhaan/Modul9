using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9PR
{
    class Flash : Storage
    {
     
        private double usbSpeed;
        private double memorySize;

        public double USB_Speed
        {
            get { return usbSpeed; }
            set { usbSpeed = value; }
        }

        public double MemorySize
        {
            get { return memorySize; }
            set { memorySize = value; }
        }

        public override double GetMemory()
        {
            return memorySize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to Flash. Size: {dataSize} GB");
        }

        public override double GetFreeMemory()
        {
          
            return memorySize * 0.9;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Flash Drive: {Name}, Model: {Model}, USB Speed: {usbSpeed} MB/s, Memory Size: {memorySize} GB");
        }
    }

}
