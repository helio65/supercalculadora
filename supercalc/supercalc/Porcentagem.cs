using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supercalc
{
    public class Porcentagem
    {
        public double Multiplicando { get; set; }
        public double Multiplicador { get; set; }
        public Porcentagem() { }

        public void Calcular()
        {
            double Valor;
            double Resultado;
            bool Sucesso;
            Console.WriteLine("\nDigite o valor!");
            Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            while (!Sucesso || Valor <= 0)
            {
                Console.WriteLine("\nDigite o valor!");
                Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            }
            Multiplicando = Valor;

            Console.WriteLine("\nDigite o percentual!");
            Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            while (!Sucesso || Valor <= 0)
            {
                Console.WriteLine("\nDigite o percentual!");
                Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            }
            Multiplicador = Valor;

            Resultado = (Multiplicando * (Multiplicador / 100));
            Console.WriteLine($"\n{Multiplicador}% de {Multiplicando} é igual a: {Resultado}");
        }
    }
}
