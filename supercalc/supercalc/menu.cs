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
            Calculadora calc = new Calculadora();
            List<string> opcoes = new List<string> { "+", "-", "*", "/", "S" };
            do
            {
                Console.WriteLine("\nSuper Calculadora");
                Console.WriteLine("\n*** Operações ***");
                Console.WriteLine("\n(+) - Somar");
                Console.WriteLine("(-) - Subtrair");
                Console.WriteLine("(*) - Multiplicar");
                Console.WriteLine("(/) - Dividir");
                Console.WriteLine("(S) - Sair");
                Console.WriteLine("\nSelecione a operação desejada!.");
                opcao = Console.ReadLine();            

                while (!opcoes.Contains(opcao))
                {
                    Console.WriteLine("\nOpção invalida, seleciona a operação desejada!.");
                    opcao = Console.ReadLine();
                }

                //Console.Clear();

                switch (opcao)
                {
                    case "+":
                        Console.WriteLine("\nSomando...");
                        break;
                    case "-":
                        Console.WriteLine("\nSubtraindo...");
                        break;
                    case "*":
                        Console.WriteLine("");
                        double multiplicandor;
                        double multiplicando;
                        double valor;
                        bool sucesso;
                        Console.WriteLine("\nDigite o primeiro valor");
                        sucesso = double.TryParse(Console.ReadLine(), out valor);
                        if (sucesso)
                        {
                            multiplicando = valor;
                        } else
                        {
                            while (!sucesso)
                            {
                                Console.WriteLine("\nDigite o primeiro valor");
                                sucesso = double.TryParse(Console.ReadLine(), out valor);
                            }
                        }

                        Console.WriteLine("\nDigite o segundo valor");
                        sucesso = double.TryParse(Console.ReadLine(), out valor);
                        if (sucesso)
                        {
                            multiplicandor = valor;
                        }
                        else
                        {
                            while (!sucesso)
                            {
                                Console.WriteLine("\nDigite o primeiro valor");
                                sucesso = double.TryParse(Console.ReadLine(), out valor);
                            }
                        }

                        break;
                    case "/":
                        Console.WriteLine("\nDividindo...");
                        break;
                }

            } while (opcao != "S");
        }
    }
}
