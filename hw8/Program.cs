using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace hw8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Storage> storages = new List<Storage>();

            storages.Add(new Flash { Name = "Flash", Model = "Transcend", SpeedUsb3_0 = 10, MemoryCapacity = 8192 });

            int totalSize = 565 * 1024; //Мб
            int fileSize = 780;         //Мб
            
            //Копирование информации на устройство
            (storages[0] as Flash).Copy(500);
            Console.WriteLine("Свободно: " + (storages[0] as Flash).GetFreeCapacity() + "Мб"); 

            //расчет необходимого количества носителей информации представленных типов для переноса информации
            int filesInOneUsb = (storages[0] as Flash).MemoryCapacity / fileSize;
            int countOfUsb = totalSize / (filesInOneUsb * 780) + 1;
            Console.WriteLine("Всего флешек надо: " + countOfUsb);

            //Вывод инфо об устрйостве
            Console.WriteLine((storages[0] as Flash).GetInfo());

            Console.ReadLine();
        }
    }
}
