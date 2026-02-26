using System;

namespace GeoApp.Models
{
    public static class Calculadora
    {
        [cite_start]// Lógica para el Desarrollador A 
        public static double AreaRectangulo(double baseR, double altura) => baseR * altura;

        [cite_start]// Lógica para el Desarrollador B
        public static double AreaCirculo(double radio) => Math.PI * Math.Pow(radio, 2);

        [cite_start]// Lógica para el Desarrollador C 
        public static double AreaTriangulo(double baseT, double altura) => (baseT * altura) / 2;
    }
}