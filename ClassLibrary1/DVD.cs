using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DVD : Storage
    {
        public int SpeedOfRead { get; set; }
        public int SpeedOfWrite { get; set; }
        public string Type { get; set; }
    }
}
