﻿using System;
using System.Collections.Generic;
using System.Threading;

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

            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }


          /*  snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);*/


            /* Point p2 = new Point(4,5,'#');
             p2.Draw();

             HorizontalLine line = new HorizontalLine(5,10,8,'+');
             line.Draw();

             VerticalLine vline = new VerticalLine(10, 20, 3, '*');
             vline.Draw();*/


            Console.ReadLine();
        }
    }
}
