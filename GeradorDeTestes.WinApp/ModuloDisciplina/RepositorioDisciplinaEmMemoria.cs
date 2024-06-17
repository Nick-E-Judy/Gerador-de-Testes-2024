using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public class RepositorioDisciplina : RepositorioBaseEmMemoria<Disciplina>, IRepositorioDisciplina
    {
        public void AdicionarMaterias(Disciplina disciplinaSelecionada, List<Materia> materias)
        {
            throw new NotImplementedException();
        }
    }
}
