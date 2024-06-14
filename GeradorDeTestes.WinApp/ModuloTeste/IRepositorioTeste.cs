using GeradorDeTestes.WinApp.ModuloDisciplina;


namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public interface IRepositorioTeste
    {
        void Cadastrar(Teste novaTeste);
        bool Editar(int id, Teste testeEditado);
        bool Excluir(int id);
        Teste SelecionarPorId(int idSelecionado);
        List<Teste> SelecionarTodos();
    }
}
