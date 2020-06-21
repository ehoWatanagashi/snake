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

            //Размер окна

            Console.SetWindowSize(79, 25);
            Console.SetBufferSize(79, 25);

            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            /* Point p1 = new Point(1,3,'*');
             p1.Draw();


             Point p2 = new Point(4,5,'#');
             p2.Draw();

             HorizontalLine line = new HorizontalLine(5,10,8,'+');
             line.Draw();

             VerticalLine vline = new VerticalLine(10, 20, 3, '*');
             vline.Draw();*/


            Console.ReadLine();
        }
    }
}
