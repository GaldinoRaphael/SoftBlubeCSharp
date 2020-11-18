using System;

namespace SoftBlubeCSharp
{
    class Program
    {
        static void Checked()
        {
            Console.WriteLine("Hello World!");
            byte b1 = 100;
            byte b2 = 200;
            //Lança uma exception caso o estoure o limite do tipo (overflow)
            // /checked habilita a checagem no compilador (Prejudica a performance da aplicação)
            //Você pode usar o unchecked para permitir o overflow nesses casos
            checked
            {
                byte soma = (byte)(b1 + b2);
            }
        }


    }
}
