using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloMateria;
using GeradorDeTestes.WinApp.ModuloTeste;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public class RepositorioQuestaoEmArquivo : RepositorioBaseEmArquivo<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Questoes.Any())
                contadorId = contexto.Questoes.Max(c => c.Id) + 1;
        }

        protected override List<Questao> ObterRegistros()
        {
            return contexto.Questoes;
        }

        public override bool Excluir(int id)
        {
            Questao questao = SelecionarPorId(id);

            List<Teste> testesRelacionados = contexto.Testes.FindAll(t => t.Questao != null && t.Questao.Id == questao.Id);

            if (testesRelacionados.Count > 0)
            {
                MessageBox.Show("Não é possível excluir a questao pois há testes relacionados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return base.Excluir(id);

        }

        public List<Questao> SelecionarPorMateria(int materiaId)
        {
            return contexto.Questoes.Where(q => q.Materia.Id == materiaId).ToList();
        }
    }
}
