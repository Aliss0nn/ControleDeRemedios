using ControleDeRemedios.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloFuncionario
{
    public class RepositorioFuncionario : RepositorioBase
    {

        public RepositorioFuncionario(ArrayList listaFuncionarios) 
        {
            this.listaRegistros = listaFuncionarios;
        }

        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Funcionario)base.SelecionarPorId(id);
        }



    }
}
