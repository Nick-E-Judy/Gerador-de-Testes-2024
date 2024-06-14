
using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {

        private Teste teste;
        public Teste Teste
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                cmbDisciplina.SelectedItem = value.Disciplina;
                cmbMateria.SelectedItem = value.Materia;
                numQtdQuestoes.Text = value.QuantQuestoes.ToString();
            }
            get
            {
                return teste;
            }
        }
        public TelaTesteForm()
        {
            InitializeComponent();
        }

        public void CarregarMaterias(List<Materia> materias)
        {
            cmbMateria.Items.Clear();

            foreach (Materia m in materias)
                cmbMateria.Items.Add(m);
        }

        public void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplina.Items.Clear();

            foreach (Disciplina m in disciplinas)
                cmbDisciplina.Items.Add(m);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;
            Materia materia = (Materia)cmbMateria.SelectedItem;
            int qtdQuestoes = Convert.ToInt32(numQtdQuestoes.Text);

            teste = new Teste(titulo, disciplina, materia, qtdQuestoes);

            List<string> erros = teste.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
