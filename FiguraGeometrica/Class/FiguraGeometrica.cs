using System;

namespace Figura
{
    
    public class FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public FiguraGeometrica(double baseFigura, double altura)
        {
            Base = baseFigura;
            Altura = altura;
        }
        public virtual double CalcularArea()
        {
            return Base * Altura;
        }

    }
    public class Rectangulo : FiguraGeometrica
    {
        public Rectangulo(double baseFigura, double altura)
            : base(baseFigura, altura)
        {
        }
        public override double CalcularArea()
        {
            return Base * Altura;  
        }
    }
    public class Cuadrado : FiguraGeometrica
    {
        public Cuadrado(double baseFigura, double altura)
            : base(baseFigura, altura)
        {
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
        
    }
}
