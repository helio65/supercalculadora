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

        public void Executar()
        {                        
            string Opcao;
            List<string> Opcoes = new List<string> { "+", "-", "*", "/", "%", "R", "Q", "S" };
            Soma ASoma = new Soma();
            Subtracao ASubtracao = new Subtracao();
            Multiplicacao AMultiplicacao = new Multiplicacao();
            Divisao ADivisao = new Divisao();
            Porcentagem APorcentagem = new Porcentagem();
            RaizQuadrada ARaizQuadrada = new RaizQuadrada();
            NumeroElevadoQuadrado ANumeroElevadoQuadrado = new NumeroElevadoQuadrado();
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
                Console.WriteLine("(Q) - Número elevado ao Quadrado");
                Console.WriteLine("(S) - Sair");
                Console.WriteLine("\nSelecione a operação desejada!.");
                Opcao = Console.ReadLine().ToUpper();            

                while (!Opcoes.Contains(Opcao))
                {
                    Console.WriteLine("\nOpção invalida, seleciona a operação desejada!.");
                    Opcao = Console.ReadLine().ToUpper();
                }

                Console.Clear();

                switch (Opcao)
                {
                    case "+":
                        ASoma.Somar();
                        break;
                    case "-":
                        ASubtracao.Subtrair();
                        break;
                    case "*":
                        AMultiplicacao.Multiplicar();
                        break;
                    case "/":
                        ADivisao.Dividir();
                        break;
                    case "%":
                        APorcentagem.Calcular();
                        break;
                    case "R":
                        ARaizQuadrada.Calcular();
                        break;
                    case "Q":
                        ANumeroElevadoQuadrado.Calcular();
                        break;
                }

            } while (Opcao != "S");
        }
    }
}
