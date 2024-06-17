using GeradorDeTestes.WinApp.ModuloDisciplina;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public interface IRepositorioQuestao
    {
        void Cadastrar(Questao novaQuestao);
        bool Editar(int id, Questao questaoEditada);
        bool Excluir(int id);
        Questao SelecionarPorId(int idSelecionado);
        List<Questao> SelecionarTodos();
        List<Questao> SelecionarPorMateria(int materiaId);
    }
}
