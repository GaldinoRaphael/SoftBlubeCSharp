using System;

namespace SoftBlubeCSharp
{
    class Program
    {
        public void ExpressoesLabda()
        {
            Predicate < T >
            //T especifica o tipo do parâmetro
            //O retorno é do tipo bool

            public class List<T>
        {
            public List<T> FindAll(Predicate<T> match);
                ..
            }

        Predicate<T> p = x => (x % 2) == 0;
        List<int> newList = list.FindAll(p);

        //ou

        List<int> newList = list.FindAll(x => (x % 2) == 0);

        //Clousures => Têm a capacidade de acessar variáveis definidas externamente
    }
}
