using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Materia materia = SelecionarPorId(id);

            List<Questao> questoesRelacionadas = contexto.Questoes.FindAll(m => m.Materia != null && m.Materia.Id == materia.Id);

            if (questoesRelacionadas != null || questoesRelacionadas.Count > 0)
            {
                MessageBox.Show("Não é possível excluir a matéria pois há questões relacionadas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return base.Excluir(id);

        }
    }
}
