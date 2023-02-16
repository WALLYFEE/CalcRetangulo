using System;
using System.Globalization;

namespace CalcRetangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;


        public double CalcArea()
        {
            return Largura * Altura;
        }
        public double CalcPerimetro()
        {
            return 2 * (Largura + Altura);
          
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
            
        }

        public override string ToString()
        {
            return "Area: "
                + CalcArea().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPerímetro: "
                + CalcPerimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDiagonal: "
                + CalcDiagonal().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
