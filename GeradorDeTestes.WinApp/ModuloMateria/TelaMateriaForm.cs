using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia;
        public Materia Materia
        {
            set
            {
                materia = value;
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                cbDisciplina.SelectedItem = value.Disciplina;
                if (value.Serie == 1)
                    rb1Serie.Checked = true;
                if (value.Serie == 2)
                    rb2Serie.Checked = true;
            }
            get
            {
                return materia;
            }
        }

        public TelaMateriaForm()
        {
            InitializeComponent();
        }

        public void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();

            foreach (Disciplina d in disciplinas)
                cbDisciplina.Items.Add(d);

            if (materia != null)
                cbDisciplina.SelectedItem = materia.Disciplina;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;
            int serie = 0;
            if (rb1Serie.Checked)
            {
                serie = 1;
            }
            else if (rb2Serie.Checked)
            {
                serie = 2;
            }

            materia = new Materia(nome, disciplina, serie);

            List<string> erros = materia.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
            else
            {
                disciplina.AdicionarMateria(materia);
            }
        }
    }
}
