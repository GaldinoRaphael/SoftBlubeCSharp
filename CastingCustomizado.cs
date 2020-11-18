using System;

namespace SoftBlubeCSharp
{
    class CastingCustomizado
    {
        public static explicit operator int(Quadrado q)
        
        {
            return q.Lado;
        }
        public static implicit operator Quadrado(int l)
        {
            return new Quadrado() { Lado = l  };
        }
        //Conversão explicita
        int l = (int)q;

        //Conversao implicita
        Quadrado 1 = 5;
    }
}
