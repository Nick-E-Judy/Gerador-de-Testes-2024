namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    partial class ListagemQuestaoControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listQuestoes = new ListBox();
            SuspendLayout();
            // 
            // listQuestoes
            // 
            listQuestoes.Dock = DockStyle.Fill;
            listQuestoes.FormattingEnabled = true;
            listQuestoes.Location = new Point(0, 0);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(669, 390);
            listQuestoes.TabIndex = 0;
            // 
            // ListagemQuestaoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listQuestoes);
            Name = "ListagemQuestaoControl";
            Size = new Size(669, 390);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listQuestoes;
    }
}
