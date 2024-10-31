using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace supercalc
{
    public class Divisao
    {
        public void Dividir()
        {
            bool deuCerto;
            double n1;
            double n2;

            while (true)
            {
                Console.WriteLine("Digite o númerador: ");
                deuCerto = double.TryParse(Console.ReadLine(), out n1);

                if (deuCerto)
                {
                    break;
                }
                Console.WriteLine("Algo deu errado, tente novamente \n");

            }
            while (true)
            {
                Console.WriteLine("Digite o denominador: ");
                deuCerto = double.TryParse(Console.ReadLine(), out n2);

                if (deuCerto)
                {
                    break;
                }
                Console.WriteLine("Algo deu errado, tente novamente \n");
            }

            if (n2 == 0)
            {
                Console.WriteLine("Não há definição para uma divisão por 0");
            }
            Console.WriteLine($"O resultado da divisão é {n1/n2}");
        }
    }
}
