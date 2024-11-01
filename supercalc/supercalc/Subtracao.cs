using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supercalc
{
    public class Subtracao
    {
        public double n1 { get; set; }
        public double n2 { get; set; }
        public void Subtrair()
        {
            double Valor;
            double Resultado;
            bool Sucesso;
            Console.WriteLine("\nDigite o minuendo!");
            Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            while (!Sucesso || Valor <= 0)
            {
                Console.Clear();
                Console.WriteLine("\nDigite o minuendo!");
                Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            }
            n1 = Valor;

            Console.WriteLine("\nDigite o subtraendo!");
            Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            while (!Sucesso || Valor <= 0)
            {
                Console.Clear();
                Console.WriteLine("\nDigite o subtraendo!");
                Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            }
            n2 = Valor;

            Console.WriteLine($"\nO resultado da subtração de {n1} de {n2} é igual a: {n1 - n2}");
        }
    }
}
