using System;

namespace SoftBlubeCSharp
{
    class Program
    {
        public void Callback()
        {
            //Um delate é um objeto capaz de apontar um metódo
            //[é um tipo]

            delegate void AvisoConsulta(DateTime horario, string obs);

            static void AgendarConsulta(DateTime horario, string obs);
            static void MostrarConsulta(DateTime horario, string obs)
            {
                //implementação
            }
            //Referencia o metódo no callback pelo delagate
            //Só pode apontar métodos que tenham assinatura compatível com a sua
            AvisoConsulta callbacks = new AvisoConsulta(MostrarConsulta);
            callbacks += new AvisoConsulta(AgendarConsulta);
            //O objeto delegate faz a chamada para o método referenciado

            callbacks(DateTime.Now, "Chegar com 10 minutos de atencedencia");

            //anotação simplificada
            AvisoConsulta callbacks = MostrarConsulta;
            callbacks += AgendarConsultas;

            //Delagate génericos são usados apra quando o nome do delegate não importa

            //Action<> (Metódos de 16 paramêtros) e retorno void
            Action<DateTime, string> callback =
                new Action<DateTime, string>(MostrarConsulta);

            //Ou simplificando    
            Action<DateTime, string> callback = MostrarConsulta;

            //Func<> (Metódos de 16 paramêtros) e permite metódos com retorno
            //O ultimo aprametro é o tipo do retorno
            Action<DateTime, string, bool> callback =
               new Action<DateTime, string>(MostrarConsulta);

            //Events
            //Quando um objeto avisa quando eventos ocorre com ele
            //Os objetos registram interesse no evento em questão e são avisados
            //Eventos usam delegates
            //É possível ter o memso comportamento do event somente com delagates 

            delegate void SapoHandler(double distancia)

            class Sapo
        {
            //Definição do evento
            public event SapoHandler Pulou;
            public void Pular()
            {
                //executa a ação
                //Passa a informação double para o delegate
                if (Pulou != null)
                    //Dispara o evento
                    Pulou(distancia);
            }
        }

        //Registrando o interesse no callback

        class Pesquisador
        {
            public Pesquisador(Sapo sapo)
            {
                //Registra o interesse no event pulou do objeto sapo
                sapo.Pulou += SapoPulou;
            }

            public void SapoPulou(double distancia)
            {
                //..executa algo quando o sapo pular
            }
        }

        //Metodos Anônimos
        static void Main()
        {
            Pessoa p = new Pessoa();
            int diaDoMes = 5;
            //Não é necessário passar parametros
            P.Acordou += delegate(Object senderm AcourdouEventArgs args)
            {
                //ele pode acessar variáveis locais definidas pelo método que o define
                Console.WriteLine(diaDoMes);
            };
        }
    }
}
}
