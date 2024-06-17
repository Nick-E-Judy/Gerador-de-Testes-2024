namespace GeradorDeTestes.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            disciplinasMenuItem = new ToolStripMenuItem();
            materiasMenuItem = new ToolStripMenuItem();
            questoesMenuItem = new ToolStripMenuItem();
            testesMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDuplicar = new ToolStripButton();
            btnVisualizar = new ToolStripButton();
            btnPDF = new ToolStripButton();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinasMenuItem, materiasMenuItem, questoesMenuItem, testesMenuItem });
            cadastrosToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(109, 29);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinasMenuItem
            // 
            disciplinasMenuItem.Name = "disciplinasMenuItem";
            disciplinasMenuItem.Size = new Size(188, 30);
            disciplinasMenuItem.Text = "Disciplinas";
            disciplinasMenuItem.Click += disciplinasMenuItem_Click;
            // 
            // materiasMenuItem
            // 
            materiasMenuItem.Name = "materiasMenuItem";
            materiasMenuItem.Size = new Size(188, 30);
            materiasMenuItem.Text = "Matérias";
            materiasMenuItem.Click += materiasMenuItem_Click;
            // 
            // questoesMenuItem
            // 
            questoesMenuItem.Name = "questoesMenuItem";
            questoesMenuItem.Size = new Size(188, 30);
            questoesMenuItem.Text = "Questões";
            questoesMenuItem.Click += questoesMenuItem_Click;
            // 
            // testesMenuItem
            // 
            testesMenuItem.Name = "testesMenuItem";
            testesMenuItem.Size = new Size(188, 30);
            testesMenuItem.Text = "Testes";
            testesMenuItem.Click += testesMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnDuplicar, btnVisualizar, btnPDF, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 35);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(29, 24);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(29, 24);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(29, 24);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnDuplicar
            // 
            btnDuplicar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDuplicar.Enabled = false;
            btnDuplicar.Image = Properties.Resources.btnDuplicar2;
            btnDuplicar.ImageTransparentColor = Color.Magenta;
            btnDuplicar.Name = "btnDuplicar";
            btnDuplicar.Size = new Size(29, 24);
            btnDuplicar.Text = "duplicar";
            btnDuplicar.Click += btnDuplicar_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Enabled = false;
            btnVisualizar.Image = Properties.Resources.btnVisualizar;
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(29, 24);
            btnVisualizar.Text = "Visualizar Testes";
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnPDF
            // 
            btnPDF.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPDF.Enabled = false;
            btnPDF.Image = Properties.Resources.btnPDF1;
            btnPDF.ImageTransparentColor = Color.Magenta;
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(29, 24);
            btnPDF.Text = "Gerar PDF";
            btnPDF.Click += btnPDF_Click;
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(123, 24);
            lblTipoCadastro.Text = "Tipo de Cadastro";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Location = new Point(0, 71);
            pnlRegistros.Margin = new Padding(3, 4, 3, 4);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(914, 529);
            pnlRegistros.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 574);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(914, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(175, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registros...";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(statusStrip1);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private Panel pnlRegistros;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem disciplinasMenuItem;
        private ToolStripMenuItem materiasMenuItem;
        private ToolStripMenuItem questoesMenuItem;
        private ToolStripMenuItem testesMenuItem;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStripButton btnDuplicar;
        private ToolStripButton btnPDF;
        private ToolStripButton btnVisualizar;
    }
}
