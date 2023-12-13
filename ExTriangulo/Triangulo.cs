using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTriangulo
{
    internal class Triangulo
    {
        private double A;
        private double B;
        private double C;

        public Triangulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool ETriangulo()
        {
            if ((A < (B + C) && (B < (A + C) && C < (B + A))
                return true;
            return false;
        }

        public string TipoTriangulo()
        {
            if (A == B && B == C) return "Equilátero";
            else if (A == B || B == C || C == A) return "Isósceles";
            else return "Escaleno";
        }

        public double AreaTriangulo()
        {
            double p = (A + B + B) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public double PerimetroTriangulo()
        {
            return (A + B + C);
        }

        public override string ToString()
        {
            return $"Dados do Triângulo:  " +
                $"\n\tLado A: {A:f2}" +
                $"\n\tLado B: {B:f2}" +
                $"\n\tLado C: {C:f2}" +
                $"\n\tTipo: {TipoTriangulo()}" +
                $"\n\tArea: {AreaTriangulo():f2}" +
                $"\n\tPerimetro: {PerimetroTriangulo():f2}";
        }
    }
}
