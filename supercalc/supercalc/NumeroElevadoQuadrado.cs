using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace supercalc
{
    public class NumeroElevadoQuadrado
    {
        public NumeroElevadoQuadrado() { }

        public void Calcular()
        {
            double Valor;
            double Quadrado;
            bool Sucesso;
            Console.WriteLine("Digite um valor!");
            Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            while (!Sucesso || Valor <= 0)
            {
                Console.WriteLine("Digite um valor!");
                Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            }
            Quadrado = Pow(Valor, 2);
            Console.WriteLine($"\n{Valor} elevado ao quadrado é igual a: {Quadrado}");
        }
    }
}
