using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public class Materia : EntidadeBase
    {
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }
        public int Serie { get; set; }
        public Materia() { }
        public Materia(string nome, Disciplina disciplina, int serie)
        {
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");  
            if (Disciplina == null)
                erros.Add("O campo \"disciplina\" é obrigatório");
            if (Serie == 0)
                erros.Add("O campo \"série\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia atualizado = (Materia)novoRegistro;

            Nome = atualizado.Nome;
            Disciplina = atualizado.Disciplina;
            Serie = atualizado.Serie;
        }

        public override string ToString()
        {
            return $"{Nome.ToTitleCase()}, {Serie}ª série";
        }
    }
}
