namespace GeradorDeTestes.WinApp.ModuloTeste
{
    partial class ListagemTesteControl
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
            listTestes = new ListBox();
            SuspendLayout();
            // 
            // listTestes
            // 
            listTestes.Dock = DockStyle.Fill;
            listTestes.FormattingEnabled = true;
            listTestes.Location = new Point(0, 0);
            listTestes.Name = "listTestes";
            listTestes.Size = new Size(649, 417);
            listTestes.TabIndex = 0;
            // 
            // ListagemTesteControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTestes);
            Name = "ListagemTesteControl";
            Size = new Size(649, 417);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listTestes;
    }
}
