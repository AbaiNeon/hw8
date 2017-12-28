using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public abstract int GetCapacity();
        public abstract void Copy(int size);
        public abstract int GetFreeCapacity();
        public abstract string GetInfo();

    }
}
