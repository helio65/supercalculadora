using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supercalc
{
    public class Menu
    {
        public Menu() 
        { 
            
        }

        public void Executor()
        {                        
            string opcao;
            List<string> opcoes = new List<string> { "+", "-", "*", "/", "S" };
            do
            {
                Console.WriteLine("\nSuper Calculadora");
                Console.WriteLine("\n*** Operações ***");
                Console.WriteLine("\n(+) - Somar");
                Console.WriteLine("(-) - Subtrair");
                Console.WriteLine("(*) - Multiplicar");
                Console.WriteLine("(/) - Dividir");
                Console.WriteLine("(%) - Porcentagem");
                Console.WriteLine("(R) - Raiz Quadrada");
                Console.WriteLine("(S) - Sair");
                Console.WriteLine("\nSelecione a operação desejada!.");
                opcao = Console.ReadLine();            

                while (!opcoes.Contains(opcao))
                {
                    Console.WriteLine("\nOpção invalida, seleciona a operação desejada!.");
                    opcao = Console.ReadLine();
                }

                Console.Clear();

                switch (opcao)
                {
                    case "+":
                        Console.WriteLine("\nSomando...");
                        break;
                    case "-":
                        Console.WriteLine("\nSubtraindo...");
                        break;
                    case "*":
                        Console.WriteLine("\nMultiplicando...");
                        break;
                    case "/":
                        Console.WriteLine("\nDividindo...");
                        break;
                }

            } while (opcao != "S");
        }
    }
}
