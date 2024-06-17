using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public class RepositorioQuestaoEmMemoria : RepositorioBaseEmMemoria<Questao>, IRepositorioQuestao
    {
        public List<Questao> SelecionarPorMateria(int materiaId)
        {
            throw new NotImplementedException();
        }
    }
}
