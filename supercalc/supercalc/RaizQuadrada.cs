using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static  System.Math;

namespace supercalc
{
    public class RaizQuadrada
    {
        public double Numero {  get; set; }
        public RaizQuadrada() { }

        public void Calcular()
        {
            double Valor;
            double Raiz;
            bool Sucesso;
            Console.WriteLine("Digite um valor para ser feito o calculo da raiz quadrada do mesmo!");
            Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            while (!Sucesso || Valor <= 0) 
            {
                Console.WriteLine("Digite um valor para ser feito o calculo da raiz quadrada do mesmo!");
                Sucesso = double.TryParse(Console.ReadLine(), out Valor);
            }
            Raiz = Sqrt(Valor);
            Console.WriteLine($"\nA raiz quadrada de {Valor} é: {Raiz}");
        }
    }
}
