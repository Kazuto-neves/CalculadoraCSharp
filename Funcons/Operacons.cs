using System;

namespace Funcons
{
    public class Operacons
    {
        public double Somar(double n1,double n2) { return n1 + n2; }
        public double Sub(double n1, double n2) { return n1 - n2; }
        public double Mult(double n1, double n2) { return n1 * n2; }
        public double Div(double n1, double n2) { return n1 / n2; }
        public double PowY(double n1, double n2) { return Math.Pow(n1,n2); }
        public double Inver(double n) { return n*-1; }
        public double Raiz(double n) { return Math.Sqrt(n); }
        public double Pow2(double n) { return Math.Pow(n,2); }
        public double Fator(double n)
        {
            double resultado = 1;
            while (n != 1)
            {
                resultado = resultado * n;
                n = n - 1;
            }
            return resultado;
        }

    }
}
