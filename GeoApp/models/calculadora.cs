using System;

namespace GeoApp.Models
{
    public static class Calculadora
    {
        [cite_start]// Lógica para el Desarrollador A: Rectángulo [cite: 30-32]
        public static double AreaRectangulo(double baseR, double altura) => baseR * altura;

        [cite_start]// Lógica para el Desarrollador B: Círculo [cite: 33-34]
        public static double AreaCirculo(double radio) => Math.PI * Math.Pow(radio, 2);

        [cite_start]// Lógica para el Desarrollador C: Triángulo [cite: 35-37]
        public static double AreaTriangulo(double baseT, double altura) => (baseT * altura) / 2;
    }
}
