using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supercalc
{
    public class Divisao
    {
        public void Dividir()
        {
            Console.WriteLine("Digite o númerador: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o denominador: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da divisão é {n1/n2}");
        }
    }
}
