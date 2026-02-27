using System;

namespace GeoApp.Models
{
    public static class Calculadora
    {
        // Lógica para el Rectángulo
        public static double AreaRectangulo(double baseR, double altura) => baseR * altura;

        // Lógica para el Círculo
        public static double AreaCirculo(double radio) => Math.PI * Math.Pow(radio, 2);

        // Lógica para el Triángulo
        public static double AreaTriangulo(double baseT, double altura) => (baseT * altura) / 2;
    }
}

//listo