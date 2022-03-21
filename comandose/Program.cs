using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandose
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Informe um número...: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                //numero = numero - 2;
                numero -= 2;
            }

            if (numero == 0)
            {
                Console.WriteLine("Número par");
            }
            else
            {
                Console.WriteLine("Número impar");
            }

            Console.ReadKey();
        }
    }
}
