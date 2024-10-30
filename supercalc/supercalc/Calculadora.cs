using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supercalc
{
    public interface ICalculadora
    {
        double Somar(List<double> numeros);
        double Subtrair(double a, double b);
        double Multiplicar(double a, double b);
        double Dividir(double a, double b);
    }

    public class Calculadora : ICalculadora
    {
        public double Somar(List<double> numeros)
        {
            return 0;
        }

        public double Subtrair(double a, double b)
        {
            return 0;
        }

        public double Multiplicar(double a, double b) 
        {
            return a * b;
        }

        public double Dividir(double a, double b) 
        { 
            return 0; 
        }
    }
}
