using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HDD : Storage
    {
        public int SpeedUsb2_0 { get; set; } //Мб/сек
        public int CountOfPartitions { get; set; } 
        public int PartitionCapacity { get; set; } //Мб
        private int _freeCapacity; //Мб
        public HDD()
        {
            _freeCapacity = GetCapacity();
        }

        public override int GetCapacity()
        {
            return PartitionCapacity * CountOfPartitions;
        }
        public override void Copy(int size)
        {
            _freeCapacity = _freeCapacity - size;
        }
        public override int GetFreeCapacity() 
        {
            return _freeCapacity;
        }
        public override string GetInfo() 
        {
            return String.Format("Объем раздела: {0}Мб - Кол-во разделов: {1} - Свободно: {2}Мб", PartitionCapacity, CountOfPartitions, _freeCapacity);
        }
    }
}
