using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supercalc
{
    public class Soma
    {
        public List<double> Numero { get; set; }

        public Soma() 
        { 
            Numero = new List<double>();
        }

        public void Somar()
        {
            string ValorX = "0";
            bool Sucesso;
            double ValorY;
            do
            {
                Console.WriteLine("Digite um valor!");
                ValorX = Console.ReadLine();
                Sucesso = double.TryParse(Console.ReadLine(), out ValorY);
                while(!Sucesso || ValorX != "=")
                {
                    Console.WriteLine("Digite um valor!");
                    ValorX = Console.ReadLine();
                    Sucesso = double.TryParse(Console.ReadLine(), out ValorY);
                }
                
                Numero.Add(ValorY);
                Console.WriteLine(Resultado(Numero).ToString());
            } while (ValorX != "=");
        }

        public double Resultado(List<double> Numero)
        {
            return Numero.Sum();
        }

    }
}
