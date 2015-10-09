using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Letters();
            int x = 8;

            for (int j = 0; j < 8; j++)
            { 
                //строка
                
                Console.Write("{0}", x);

                for (int i = 0; i < 8; i++)
                {
                    if (i % 2 == 0) Console.Write(" ");
                    else Console.Write("#");
                }
                
               Console.Write("{0}", x);
               x = x - 1;
               Console.WriteLine();

              
                 
            }
            Letters();
            Console.ReadKey();     
        }

        private static void Letters()
        {
            Console.WriteLine(" ABCDEFGH ");
        }
        
    }
}
