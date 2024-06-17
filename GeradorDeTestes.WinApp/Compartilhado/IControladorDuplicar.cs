using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.Compartilhado
{
    public interface IControladorDuplicar
    {
        string ToolTipDuplicar { get; }
        void Duplicar();
    }
}
