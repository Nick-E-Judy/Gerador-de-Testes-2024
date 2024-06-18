using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloQuestao;
using GeradorDeTestes.WinApp.ModuloTeste;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioBaseEmArquivo<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Materias.Any())
                contadorId = contexto.Materias.Max(c => c.Id) + 1;
        }

        protected override List<Materia> ObterRegistros()
        {
            return contexto.Materias;
        }

        public override bool Excluir(int id)
        {
            Materia questao = SelecionarPorId(id);

            List<Questao> questoesRelacionadas = contexto.Questoes.FindAll(m => m.Materia != null && m.Materia.Id == questao.Id);

            if (questoesRelacionadas.Count > 0)
                return false;

            return base.Excluir(id);
        }

        public List<Materia> SelecionarPorDisciplina(int disciplinaId)
        {
            return contexto.Materias.Where(m => m.Disciplina.Id == disciplinaId).ToList();
        }
    }
}
