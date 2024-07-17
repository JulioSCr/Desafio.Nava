using Desafio.Nava.Console.Atividades;
using Desafio.Nava.Console.Interfaces;

namespace Desafio.Nava.Console.CasoUso
{
    public class TrabalhandoAtividades
    {
        private readonly IAtividadeServico _servico;

        public TrabalhandoAtividades(IAtividadeServico servico)
        {
            _servico = servico;
        }

        public void Usar()
        {
            var trabalho = new List<IAtividade>()
            {
                new Atividade("Planejamento da demanda"),
                new Atividade("Construção de cronograma de desenvolvimento")
            };

            var estudo = new List<IAtividade>()
            {
                new Atividade("Estudo sobre DDD"),
                new Atividade("Estudo sobre Azure")
            };

            var lazer = new List<IAtividade>()
            {
                new Atividade("Ler um livro"),
                new Atividade("Praticar música")
            };

            _servico.ConcluirAtividade(trabalho[0]);
            _servico.ConcluirAtividade(estudo[1]);

            AtividadePresenter(trabalho, nameof(trabalho));
            AtividadePresenter(estudo, nameof(estudo));
            AtividadePresenter(lazer, nameof(lazer));
        }

        public void AtividadePresenter(IList<IAtividade> atividades, string descricao)
        {
            for (int i = 0; i < atividades.Count; i++)
            {
                System.Console.WriteLine($"{descricao} {i+1}: Está Concluído = {atividades[i].EstaConcluida.ToString().ToLower()}");
            }
        }
    }
}
