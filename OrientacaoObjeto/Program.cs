using System;
using System.Globalization;

namespace OrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instância da Classe Tringulo
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            //Entrada de Dados
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Entrada de Dados
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Realização do cálculo
            float p = (float)((x.A + x.B + x.C) / 2.0);
            float areaX = (float)Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (float)((y.A + y.B + y.C) / 2.0);
            float areaY = (float)Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            //Print dos valores de área já calculados pela Classe
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //Definição de qual área é a maior
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}


