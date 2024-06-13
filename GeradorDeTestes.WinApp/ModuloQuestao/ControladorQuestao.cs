using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private IRepositorioQuestao repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestao;


        public ControladorQuestao(IRepositorioQuestao repositorio)
        {
            repositorioQuestao = repositorio;
        }

        public override string TipoCadastro { get { return "Questoes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova questao"; } }

        public override string ToolTipEditar { get { return "Editar uma questao existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma questao existente"; } }

        public override void Adicionar()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm();

            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questao novaQuestao = telaQuestao.Questao;

            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            foreach (var questao in questoes)
            {
                if (questao.Enunciado.ToLower() == novaQuestao.Enunciado.ToLower())
                {
                    MessageBox.Show(
                        "Já existe uma questao com este nome.",
                        "Erro de Validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            repositorioQuestao.Cadastrar(novaQuestao);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaQuestao.Enunciado}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            TelaQuestaoForm telaQuestao = new TelaQuestaoForm();
            telaQuestao.Questao = questaoSelecionada;

            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questao questaoEditada = telaQuestao.Questao;

            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            foreach (var questao in questoes)
            {
                if (questao.Enunciado.ToLower() == questaoEditada.Enunciado.ToLower() && questao.Id != questaoSelecionada.Id)
                {
                    MessageBox.Show(
                        "Já existe uma questao com este nome.",
                        "Erro de Validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            repositorioQuestao.Editar(questaoSelecionada.Id, questaoEditada);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{questaoEditada.Enunciado}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{questaoSelecionada.Enunciado}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioQuestao.Excluir(questaoSelecionada.Id);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{questaoSelecionada.Enunciado}\" foi excluído com sucesso!");
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(questoes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestao == null)
                tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestao;
        }
    }
}
