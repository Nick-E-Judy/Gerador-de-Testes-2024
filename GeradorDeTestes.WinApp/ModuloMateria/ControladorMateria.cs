using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private IRepositorioMateria repositorioMateria;
        private TabelaMateriaControl tabelaMateria;
        private IRepositorioDisciplina repositorioDisciplina;

        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string TipoCadastro { get { return "Materias"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova materia"; } }

        public override string ToolTipEditar { get { return "Editar uma materia existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma materia existente"; } }

        public override void Adicionar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm();

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaMateria.CarregarDisciplinas(disciplinasCadastradas);

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materia novaMateria = telaMateria.Materia;

            List<Materia> materias = repositorioMateria.SelecionarTodos();

            VerificarNome(novaMateria, materias);

            repositorioMateria.Cadastrar(novaMateria);

            CarregarMaterias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaMateria.Nome}\" foi criado com sucesso!");

        }

        public override void Editar()
        {
            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionada == null)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }

            TelaMateriaForm telaMateria = new TelaMateriaForm();
            telaMateria.Materia = materiaSelecionada;

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaMateria.CarregarDisciplinas(disciplinasCadastradas);

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materia materiaEditada = telaMateria.Materia;

            List<Materia> materias = repositorioMateria.SelecionarTodos();

            VerificarNome(materiaEditada, materias);

            repositorioMateria.Editar(materiaSelecionada.Id, materiaEditada);

            CarregarMaterias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{materiaEditada.Nome}\" foi editado com sucesso!");

        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionada =
                repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionada == null)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{materiaSelecionada.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioMateria.Excluir(materiaSelecionada.Id);

            CarregarMaterias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{materiaSelecionada.Nome}\" foi excluído com sucesso!");
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMateria;
        }
        private static void VerificarNome(Materia materiaRecebida, List<Materia> materias)
        {
            foreach (var materia in materias)
            {
                if (materia.Nome.ToLower() == materiaRecebida.Nome.ToLower())
                {
                    TelaPrincipalForm
                        .Instancia
                        .AtualizarRodape($"Já existe uma materia com este nome.");
                    return;
                }
            }
        }
    }
}
