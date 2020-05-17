using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class rowOfData
    {
        public float interval { get; set; }

        public float objectsAmount { get; set; }

        //Общее время
        public float time { get; set; }

        //Вероятность безотказной работы
        public float p { get; set; }

        //Частота
        public float alpha { get; set; }

        //Интенсивность
        public float lambda { get; set; }
    }
}
