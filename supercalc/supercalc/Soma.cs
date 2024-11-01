using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supercalc
{
    public class Soma
    {
        public List<double> Numeros { get; set; }

        public Soma() 
        { 
            Numeros = new List<double>();
        }

        public void Somar()
        {
            string ValorX;
            bool Sucesso;                                 

            while (true)
            {
                Console.WriteLine("Digite um valor ou ( = ) para finalizar!");
                ValorX = Console.ReadLine();

                if (ValorX == "=")
                {
                    break;
                }

                if (double.TryParse(ValorX, out double numero))
                {
                    Numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido ou '=' para sair.");
                }

                Console.Clear();
                
            }

            double Reultado = 0;

            foreach (var num in Numeros)
            {
                Reultado += num;
            }

            Numeros.Clear();

            Console.Clear();

            Console.WriteLine($"\nA soma dos números digitados é: {Reultado}");
        }

    }
}
