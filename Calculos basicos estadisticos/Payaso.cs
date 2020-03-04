using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos_basicos_estadisticos
{
    class Payaso
    {
        public string[] Tipo = { "Moneda", "Almacenamiento", };
        public string[][] etiquetas =
      {
            new string [] {"dolares", "colones sv", "yanes", "rupias", "peso chileno", "peso mexicano", "peso argentino", "bitcoin",},
            new string [] {"MegaBytes", "bit", "byte", "kilobyte", "gigabyte", "terabyte",},
        };
        double[][] valores =
        {
            new double[] {1, 8.75, 111.27, 69.75, 667.08, 19.36, 39.69, 0.00026 },
            new double[] {1, 8, 388, 608, 1, 048, 576, 1, 024, 0.0009765625, 0.00000095367431660625 }, 
        };
        public double convertir(int de, int a, double cantidad, int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad, 2);
        }
    }
}
