//Если основная программа вызывает методы по очереди, то их сложности складываются: O(n^2 )+O(n^3)=O(n^3). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedure
{
    class Program
    {

        // Степень роста метода DoSlowly O(n^3)  

        static void DoSlowly(int n)
        {
            int a = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)                     
                                                                       
                    {                                                  
                        a++;
                    }
                }
            }

            Console.WriteLine("a = {0}", a);
        }

        // Степень роста метода DoFastly O(n^2)
        
        static void DoFastly(int n)
        {
            int b = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b++;
                }
            }
        }
        
        static void Main(string[] args)
        {

            DoSlowly(3); // 27
            DoFastly(5); // 25

            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}
