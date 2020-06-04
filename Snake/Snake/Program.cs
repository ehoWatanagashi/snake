using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проблемы с кодировкой. Вместо русских символов знаки "?". 
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Point p1 = new Point(1,3,'*');
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw();


            Point p2 = new Point(4,5,'#');
/*            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';*/
            p2.Draw();


            Console.ReadLine();
        }
    }
}
