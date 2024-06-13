using GeradorDeTestes.WinApp.Compartilhado;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            grid.Rows.Clear();

            foreach (Questao c in questoes)
                grid.Rows.Add(c.Id, c.Enunciado.ToTitleCase());
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado" },
                        };
        }
    }
}
