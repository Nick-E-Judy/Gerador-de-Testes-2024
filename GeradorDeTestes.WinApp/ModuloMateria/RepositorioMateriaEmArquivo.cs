using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;
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

            return base.Excluir(id);
        }
    }
}
