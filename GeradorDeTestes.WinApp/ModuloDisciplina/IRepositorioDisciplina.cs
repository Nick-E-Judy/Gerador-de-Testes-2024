using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void Cadastrar(Disciplina novaDisciplina);
        bool Editar(int id, Disciplina disciplinaEditada);
        bool Excluir(int id);
        Disciplina SelecionarPorId(int idSelecionado);
        void AdicionarMaterias(Disciplina disciplinaSelecionada, List<Materia> materias);
        List<Disciplina> SelecionarTodos();
    }
}
