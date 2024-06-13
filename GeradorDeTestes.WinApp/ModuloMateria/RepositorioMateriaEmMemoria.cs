using GeradorDeTestes.WinApp.Compartilhado;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public class RepositorioMateriaEmMemoria : RepositorioBaseEmMemoria<Materia>, IRepositorioMateria
    {
    }
}
