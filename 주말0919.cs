using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;



namespace gameProject
{
    internal class Program
    {
        class BaseClass
        {
            public int m_x, m_y, m_z;
            private int m_i;
            public void Set_N_Show()
            {
                m_i = 3;
                m_x = 111;
                m_y = 222;
                m_z = 333;
                Console.WriteLine("부모클래스 메서드" + m_i);
                Console.WriteLine("멤버값 {0}  {1}   {2}", m_x, m_y, m_z);
            }
            public void Show1()
            {
                Console.WriteLine("부모클래스 메서드");
                Console.WriteLine("부모 멤버값 {0}  {1}   {2}", m_x, m_y, m_z);
            }
        }
        class SubClasee : BaseClass
        {
            public int m_a, m_b;
            public void Show2()
            {
                // m_i = 6; //error
                Console.WriteLine("자식클래스 메서드");
                m_a = 999;
                m_b = 888;
                Console.WriteLine("멤버값 {0}  {1}", m_a, m_b);
            }
        }

        static void Main(string[] args)
        {
            BaseClass pbase = new BaseClass();
            Console.WriteLine("-------부모-----------");
            pbase.Set_N_Show();

            Console.WriteLine("-------자식-----------");
            SubClasee psub = new SubClasee();
            psub.m_a = 1;//sub 전용
            psub.m_x = 2; //sub 이전의 기반클래스 Base
            Console.WriteLine("{0} {1} {2}", psub.m_x, psub.m_y, psub.m_z);
            Console.WriteLine("{0}  {1}", psub.m_a, psub.m_b);

            Console.WriteLine("-----------------------");
            psub.Set_N_Show();
            Console.WriteLine("-----------------------");
            psub.Show1();
            psub.Show2();
        }
    }
}
