using System;
namespace OrientacaoObjeto
{
    class Triangulo
    {
        public float A;
        public float B;
        public float C;
        public float Area()
        {
            float p = (float)((A + B + C) / 2.0);
            return (float)Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}