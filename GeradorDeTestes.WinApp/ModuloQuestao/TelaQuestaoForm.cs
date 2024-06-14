using GeradorDeTestes.WinApp.ModuloMateria;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public partial class TelaQuestaoForm : Form
    {

        private Questao questao;
        private char proximaLetra = 'A';
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
        public List<Alternativa> AlternativasAdicionadas
        {
            get
            {
                return listAlternativas.Items.Cast<Alternativa>().ToList();
            }
        }

        public TelaQuestaoForm()
        {
            InitializeComponent();
        }
        public void CarregarMaterias(List<Materia> materias)
        {
            cmbMateria.Items.Clear();

            foreach (Materia m in materias)
                cmbMateria.Items.Add(m);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string enunciado = txtEnunciado.Text;
            Materia materia = (Materia)cmbMateria.SelectedItem;
            foreach (Alternativa alternativa in listAlternativas.Items)
            {
                int itemIndex = listAlternativas.Items.IndexOf(alternativa);
                alternativa.Correto = listAlternativas.GetItemChecked(itemIndex);
            }
            List<Alternativa> alternativas = listAlternativas.Items
            .Cast<Alternativa>()
            .ToList();

            questao = new Questao(enunciado, alternativas, materia);

            List<string> erros = questao.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResposta.Text))
            {
                MessageBox.Show("A resposta não pode estar vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AlternativasAdicionadas.Any(x => x.Resposta == txtResposta.Text))
            {
                MessageBox.Show("Esta resposta já foi adicionada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Alternativa alternativaEnunciado = new Alternativa(proximaLetra, txtResposta.Text, false);

            listAlternativas.Items.Add(alternativaEnunciado);

            proximaLetra++;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listAlternativas.SelectedItem is Alternativa alternativaSelecionada)
            {
                listAlternativas.Items.Remove(alternativaSelecionada);

                ReordenarAlternativas();

                proximaLetra = (char)('A' + listAlternativas.Items.Count);
            }
        }

        private void ReordenarAlternativas()
        {
            int index = 0;
            foreach (Alternativa alternativa in listAlternativas.Items)
            {
                alternativa.Letra = (char)('A' + index);
                index++;
            }

            // Atualizar a lista para refletir as mudanças na UI
            listAlternativas.Refresh();
        }
        private void listAlternativas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < listAlternativas.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        listAlternativas.SetItemChecked(i, false);
                    }
                }
            }
        }
    }
}
