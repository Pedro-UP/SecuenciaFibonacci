using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuenciaFibonacci
{
    class Program
    {
        static int x = 1, j = 0, secu;
        static int n = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese valor");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <=n; i++)
            {
                secu = j + x;
                Console.WriteLine(secu);
                j = x;
                x = secu;

                
            }
                
           
                
            
            Console.ReadLine();
        }
    }
}
