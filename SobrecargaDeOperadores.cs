using System;

namespace SoftBlubeCSharp
{
    class Program
    {
        static void SobrecargaDeOperadores(string[] args)
        {
            if(q1 > q2){}

            q++;
        }
        //Operator é a palavra reservada para a reescrita
        public static bool operator >(Quadrado q1, Quadrado q2){
            return q1.lado > q2.lado;
        }
        public static bool operator <(Quadrado q1, Quadrado q2){
            return q1.lado < q2.lado;
        }

        public static Quadrado operator ++ (Quadrado q){
            return new Quadrado(q.lado + 1);
        }


    }
}
