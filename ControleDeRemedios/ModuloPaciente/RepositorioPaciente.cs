using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloPaciente
{

    public class RepositorioPaciente : RepositorioBase
    {
              
        public RepositorioPaciente(ArrayList listaPacientes)
        {
            this.listaRegistros = listaPacientes;
        }

        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Paciente)base.SelecionarPorId(id);
        }


    }

}
