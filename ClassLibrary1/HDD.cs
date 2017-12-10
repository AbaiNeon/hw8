using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HDD : Storage
    {
        public int SpeedUsb2_0 { get; set; }
        public int CountOfPartitions { get; set; }
        public int PartitionCapacity { get; set; }
    }
}
