using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake";
            
            Point p1 = new Point(10,10,'+');
            p1.Draw();


            Point p2 = new Point(4,5,'#');
            p2.Draw();

            List<int> numList =new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            //List<Point> tmpList = new List<Point>();
            
            //for (int i = 0; i < 50; i++)
            //{
            //    tmpList.Add(i);
            //}

            //foreach (int i in tmpList)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
