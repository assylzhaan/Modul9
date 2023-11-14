using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9PR
{
    class DVD : Storage
    {
        private double readWriteSpeed;
        private bool doubleSided;
        private double capacity;

        
        public double ReadWriteSpeed
        {
            get { return readWriteSpeed; }
            set { readWriteSpeed = value; }
        }

        public bool DoubleSided
        {
            get { return doubleSided; }
            set { doubleSided = value; }
        }

        public double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

   
        public override double GetMemory()
        {
            return capacity;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to DVD. Size: {dataSize} GB");
        }

        public override double GetFreeMemory()
        {
            
            return 0;
        }

        public override void DisplayInfo()
        {
            string type = doubleSided ? "Double-Sided" : "Single-Sided";
            Console.WriteLine($"DVD: {Name}, Model: {Model}, Read/Write Speed: {readWriteSpeed} MB/s, Type: {type}, Capacity: {capacity} GB");
        }
    }
}
