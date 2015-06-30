using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundationLearn
{
    internal class A
    {
        public static int X;

        static A()   //2,执行后到5，
        {
            X = B.Y + 1;//1
        }
    }

    internal class B
    {
        public static int Y = A.X + 1;//1.先执行A类中的构造函数，3.->2

        static B()          /*4.->1*/
        {
            Y = 1;
        }

        private static void Main()  /*5.如果Main该类中有静态的构造函数，
                             * 就先执行该静态构造函数，跳到2.*/
        {
            Console.WriteLine("X={0},Y={1}", A.X, B.Y);
            Console.Read();
        }
    }
}