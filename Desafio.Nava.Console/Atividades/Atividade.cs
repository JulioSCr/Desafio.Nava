using Desafio.Nava.Console.Interfaces;

namespace Desafio.Nava.Console.Atividades
{
    public class Atividade : IAtividade
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public bool EstaConcluida { get; private set; }

        public Atividade(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            EstaConcluida = false;
        }

        public void ConcluirAtividade()
        {
            if (EstaConcluida)
                throw new InvalidOperationException("A atividade já está concluída!");

            EstaConcluida = true;
        }
    }
}
