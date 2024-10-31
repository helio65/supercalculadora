using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supercalc
{
    internal class Soma
    {
        public double n1 { get; set; }
        public double n2 { get; set; }
        public void Somar()
        {
            Console.Write("Digite numero 01:");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite numero 02:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado: {n1 + n2}");
        }
    }
}
