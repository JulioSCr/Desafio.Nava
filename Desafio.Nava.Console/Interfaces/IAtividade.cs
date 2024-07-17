namespace Desafio.Nava.Console.Interfaces
{
    public interface IAtividade
    {
        Guid Id { get; }
        string Nome { get; }
        bool EstaConcluida { get; }
        void ConcluirAtividade();
    }
}
