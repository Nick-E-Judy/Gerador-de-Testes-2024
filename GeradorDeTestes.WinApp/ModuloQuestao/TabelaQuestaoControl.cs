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

            foreach (Questao q in questoes)
            {
                string alternativaCorreta = q.Alternativas.FirstOrDefault(a => a.Correto)?.Letra.ToString() ?? "-";

                grid.Rows.Add(q.Id, q.Enunciado.ToTitleCase(), q.Materia.Nome, alternativaCorreta);
            }
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Matéria" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Alternativas", HeaderText = "Alternativa correta" },
                        };
        }
    }
}
