using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supercalc
{
    public class Divisao
    {
        public double n1 { get; set; }
        public double n2 { get; set; }
        public void Dividir()
        {
            double Valor;
            double Resultado;
            bool Sucesso;
            Console.WriteLine("\nDigite o dividendo!");
            Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            while (!Sucesso || Valor <= 0)
            {
                Console.Clear();
                Console.WriteLine("\nDigite o dividendo!");
                Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            }
            n1 = Valor;

            Console.WriteLine("\nDigite o divisor!");
            Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            while (!Sucesso || Valor <= 0)
            {
                Console.Clear();
                Console.WriteLine("\nDigite o divisor!");
                Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            }
            n2 = Valor;

            Console.WriteLine($"\nO resultado da divisão de {n1} por {n2} é igual a: {n1/n2}");
        }
    }
}
