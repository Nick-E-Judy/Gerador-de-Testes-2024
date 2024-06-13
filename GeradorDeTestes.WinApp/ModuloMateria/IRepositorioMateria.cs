using GeradorDeTestes.WinApp.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public interface IRepositorioMateria
    {
        void Cadastrar(Materia novaMateria);
        bool Editar(int id, Materia materiaEditada);
        bool Excluir(int id);
        Materia SelecionarPorId(int idSelecionado);
        List<Materia> SelecionarTodos();
    }
}
