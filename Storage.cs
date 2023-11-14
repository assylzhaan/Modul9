﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9PR
{
    abstract class Storage
    {
       
        private string name;
        private string model;

        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

      
        public abstract double GetMemory();

        public abstract void CopyData(double dataSize);

        public abstract double GetFreeMemory();

        public abstract void DisplayInfo();
    }
}
