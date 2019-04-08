using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.setWidth(100);
            rect.setHeight(20);
            Console.WriteLine(rect.Area == 100 * 20);

            Rectangle squ = new Square();
            squ.setWidth(100);
            squ.setHeight(20);
            Console.WriteLine(squ.Area == 100 * 20);

            Console.ReadKey();
        }
    }

    class Rectangle
    {
        public double m_width;
        public double m_height;

        public virtual void setWidth(double width)
        {
            m_width = width;
        }
        public virtual void setHeight(double height)
        {
            m_height = height;
        }

        public double Area
        {
            get
            {
                return m_width * m_height;
            }
        }
    }

    /// <summary>
    /// 正方形只有长的概念，而没有长方形所期望的宽的概念，所以长方形中定义了正方形根本没有的东西，长方形不应该是正方形的基类
    /// 当一个基类出现了其子类不想要的接口成员时，继承关系必然是欠缺考虑的继承，也必然是违反LSP原则的
    /// </summary>
    class Square:Rectangle
    {
        public override void setHeight(double height)
        {
            m_height = height;
            m_width = height;
        }
        public override void setWidth(double width)
        {
            m_height = width;
            m_width = width;
        }
    }
}
