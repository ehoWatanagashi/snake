﻿using System;

namespace Snake
{
    class Program
    {
/*        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }*/
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            /*Draw(p1.x, p1.y, p1.sym);*/

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();

            /* Draw(p2.x, p2.y, p2.sym);*/

            /* int x1 = 1;
             int y1 = 3;
             char sym1 = '*';

             Draw(x1, y1, sym1);

             int x2 = 4;
             int y2 = 5;
             char sym2= '#';

             Draw(x2, y2, sym2);*/

            Console.ReadLine();
        }
    }
}
