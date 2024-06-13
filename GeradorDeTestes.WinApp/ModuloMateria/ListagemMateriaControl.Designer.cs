namespace GeradorDeTestes.WinApp.ModuloMateria
{
    partial class ListagemMateriaControl
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
            listMaterias = new ListBox();
            SuspendLayout();
            // 
            // listMaterias
            // 
            listMaterias.Dock = DockStyle.Fill;
            listMaterias.FormattingEnabled = true;
            listMaterias.ItemHeight = 15;
            listMaterias.Location = new Point(0, 0);
            listMaterias.Name = "listMaterias";
            listMaterias.Size = new Size(221, 192);
            listMaterias.TabIndex = 0;
            // 
            // ListagemMateriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listMaterias);
            Name = "ListagemMateriaControl";
            Size = new Size(221, 192);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listMaterias;
    }
}
