using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        // 定義一個二維座標類
        class Point2D
        {
            int _x;
            int _y;

            public Point2D(int x,int y)
            {
                _x = x;
                _y = y;
            }

            /*
             * 多載 + 號、 - 號運算子
             * 讓 Point2D 類在處理 + 號運算子時依照下列的規則進行運算
             */
            public static Point2D operator +(Point2D p1,Point2D p2) =>
                new Point2D(p1._x + p2._x,p1._y + p2._y);

            public static Point2D operator -(Point2D p1,Point2D p2) =>
                new Point2D(p1._x - p2._x,p1._y - p2._y);

            // 覆寫 ToString() 方法
            public override string ToString()
            {
                return "(" + this._x + "," + this._y + ")";
            }
            

        }

        static void Main(string[] args)
        {
            Point2D p1 = new Point2D(3, 5);
            Point2D p2 = new Point2D(2, 4);

            Console.WriteLine("p1 : " + p1);

            Console.WriteLine("p2 : " + p2);

            /*
             * 這樣就可以對 Point2D 類的物件使用多載後的運算子來進行運算。
             */
            Console.WriteLine("p1 + p2 = " + (p1 + p2));

            Console.WriteLine("p1 - p2 = " + (p1 - p2));
        }
    }
}
