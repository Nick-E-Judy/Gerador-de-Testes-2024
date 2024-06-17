using GeradorDeTestes.WinApp.Compartilhado;
using static System.Net.Mime.MediaTypeNames;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Teste> testes)
        {
            grid.Rows.Clear();
            foreach (Teste c in testes) 
            {
                string materiaOuRecuperacao = c.Materia != null ? c.Materia.Nome : "Recuperação";
                grid.Rows.Add(c.Id, c.Titulo.ToTitleCase(), c.Disciplina.Nome.ToTitleCase(), materiaOuRecuperacao.ToTitleCase(), c.QuantQuestoes);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia" },
                new DataGridViewTextBoxColumn { DataPropertyName = "QuantQuestoes", HeaderText = "Qtd de Questoes" },
                        };
        }
    }
}
