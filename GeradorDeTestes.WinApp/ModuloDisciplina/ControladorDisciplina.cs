﻿using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloMateria;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private TabelaDisciplinaControl tabelaDisciplina;

        public ControladorDisciplina(IRepositorioDisciplina repositorio)
        {
            repositorioDisciplina = repositorio;
        }

        public override string TipoCadastro { get { return "Disciplinas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar uma disciplina existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma disciplina existente"; } }

        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina novaDisciplina = telaDisciplina.Disciplina;

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            foreach (var disciplina in disciplinas)
            {
                if (disciplina.Nome.ToLower() == novaDisciplina.Nome.ToLower())
                {
                    TelaPrincipalForm
                        .Instancia
                        .AtualizarRodape($"Já existe uma disciplina com este nome");
                    return;
                }
            }

            repositorioDisciplina.Cadastrar(novaDisciplina);

            CarregarDisciplinas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaDisciplina.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada = repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }

            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();
            telaDisciplina.Disciplina = disciplinaSelecionada;

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina disciplinaEditada = telaDisciplina.Disciplina;

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            foreach (var disciplina in disciplinas)
            {
                if (disciplina.Nome.ToLower() == disciplinaEditada.Nome.ToLower() && disciplina.Id != disciplinaSelecionada.Id)
                {
                    TelaPrincipalForm
                        .Instancia
                        .AtualizarRodape($"Já existe uma disciplina com este nome.");
                    return;
                }
            }

            repositorioDisciplina.Editar(disciplinaSelecionada.Id, disciplinaEditada);

            CarregarDisciplinas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{disciplinaEditada.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada = repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado");
                return;
            }
            
            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{disciplinaSelecionada.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            bool conseguiuExcluir = repositorioDisciplina.Excluir(disciplinaSelecionada.Id);

            if (!conseguiuExcluir)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível excluir a disciplina pois há matérias relacionadas.");
                return;
            }

            CarregarDisciplinas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{disciplinaSelecionada.Nome}\" foi excluído com sucesso!");
        }

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplina.AtualizarRegistros(disciplinas);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarDisciplinas();

            return tabelaDisciplina;
        }

    }
}
