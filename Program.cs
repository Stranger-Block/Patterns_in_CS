using System;

namespace Programm
{
    class Code
    {
        public void RHP()
        {
            Console.WriteLine("");
            Console.WriteLine("Inverted Right Half Pyramid");
            Console.WriteLine("");

            for (int i = 0; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            } 
        }

        public void LHP()
        {
            Console.WriteLine("");
            Console.WriteLine("Left Half Pyramid");
            Console.WriteLine("");

            for (int i = 0; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(" "); 
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        }

        public void INHP()
        {
            Console.WriteLine("");
            Console.WriteLine("Inverted Left Half Pyramid");
            Console.WriteLine("");

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" "); 
                }

                for (int k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        }

        public void IFP()
        {
            Console.WriteLine("");
            Console.WriteLine("Inverted Full Pyramid");
            Console.WriteLine("");

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" "); 
                }

                for (int k = i; k <= 5; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
            }
        }

        public void RP()
{
    Console.WriteLine("");
    Console.WriteLine("Rhombus Pattern");
    Console.WriteLine("");

    for (int i = 0; i <= 5; i++)
    {
        for (int j = 0; j <= i; j++) 
        {
            Console.Write(" "); 
        }

        for (int k = 0; k <= 5; k++)
        {
            Console.Write("* ");
        }

        Console.WriteLine("");
    }
}
        static void Main(string[] args)
        {
            Code m1 = new Code();

            m1.RHP();
        }

    }
}












