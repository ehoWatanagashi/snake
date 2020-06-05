using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проблемы с кодировкой. Вместо русских символов знаки "?". 
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Point p1 = new Point(1,3,'*');
            p1.Draw();


            Point p2 = new Point(4,5,'#');
            p2.Draw();

            //создание списка (нужно подключить директиву using System.Collections.Generic;)
            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            //вывод всех значений списка
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            //удаление значений
            numList.RemoveAt(0);

            //список, содержащий точки
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            Console.ReadLine();
        }
    }
}
