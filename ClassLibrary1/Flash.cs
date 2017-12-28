using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Flash : Storage
    {
        public int SpeedUsb3_0 { get; set; } //Мб/сек
        public int MemoryCapacity { get; set; } //Мб
        private int _freeCapacity; //Мб
        public Flash()
        {
            _freeCapacity = 8 * 1024;
        }

        public override int GetCapacity()
        {
            return MemoryCapacity;
        }
        public override void Copy(int size)
        {
            _freeCapacity = _freeCapacity - size;
        }
        public void Clean()
        {
            _freeCapacity = 8 * 1024;
        }
        public override int GetFreeCapacity()
        {
            return _freeCapacity;
        }
        public override string GetInfo()
        {
            return String.Format("Скорость Usb: {0}Мб/с - Объем памяти: {1} - Свободно: {2}Мб", SpeedUsb3_0, MemoryCapacity, _freeCapacity);
        }
    }
}
