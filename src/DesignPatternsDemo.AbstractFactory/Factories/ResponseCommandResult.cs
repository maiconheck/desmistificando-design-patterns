using System;

namespace DesignPatternsDemo.AbstractFactory.Factories
{
    public partial class FooControllerTest
    {
        public class ResponseCommandResult
        {
            public ResponseCommandResult(string id, int codigo, string mensagem)
            {
                Id = new Guid(id);
                Codigo = codigo;
                Mensagem = mensagem;
            }

            public ResponseCommandResult(int codigo, string mensagem)
            {
                Codigo = codigo;
                Mensagem = mensagem;
            }

            public Guid? Id { get; set; }

            public string Mensagem { get; set; }

            public int Codigo { get; set; }
        }
    }
}