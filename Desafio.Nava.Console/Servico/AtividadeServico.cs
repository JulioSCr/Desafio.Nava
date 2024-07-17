using Desafio.Nava.Console.Interfaces;

namespace Desafio.Nava.Console.Servico
{
    public class AtividadeServico : IAtividadeServico
    {
        public void ConcluirAtividade(IAtividade atividade)
            => atividade.ConcluirAtividade();
    }
}
