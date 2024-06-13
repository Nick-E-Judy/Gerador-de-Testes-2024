using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public partial class TelaQuestaoForm : Form
    {
     
        private Questao questao;
        public Questao Questao
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtEnunciado.Text = value.Enunciado;
                cmbMateria.SelectedItem = value.Materia;
            }
            get
            {
                return questao;
            }
        }

        public TelaQuestaoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string enunciado = txtEnunciado.Text;
            Materia materia = (Materia)cmbMateria.SelectedItem;
            //List<string> alternativas = listAlternativas.Items;

            questao = new Questao(enunciado, materia);

            List<string> erros = questao.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
