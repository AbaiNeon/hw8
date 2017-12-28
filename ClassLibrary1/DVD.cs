using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DVD : Storage
    {
        public int SpeedOfRead { get; set; } //Мб/с
        public int SpeedOfWrite { get; set; }
        public string Type { get; set; }
        private int _freeCapacity; //Мб
        public DVD()
        {
            _freeCapacity = GetCapacity();
        }
        public override int GetCapacity()
        {
            if (Type == "oneSided")
            {
                return 4812; //Мб (=4,7Гб)
            }
            else
            {
                return 9216; //=9Гб
            }
            
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
            return String.Format("Скорость чтения: {0}Мб/с - Скорость записи: {1}Мб/с - Тип: {2}", SpeedOfRead, SpeedOfWrite, Type);
        }
    }
}
