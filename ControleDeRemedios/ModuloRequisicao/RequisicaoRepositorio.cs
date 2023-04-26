using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloAquisicao;
using ControleDeRemedios.ModuloFuncionario;
using ControleDeRemedios.ModuloMedicamento;
using ControleDeRemedios.ModuloPaciente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloRequisicao
{
    public class RequisicaoRepositorio : RepositorioBase
    {
       
        public RequisicaoRepositorio(ArrayList listaRequisicao)
        {
            this.listaRegistros = listaRequisicao;
        }

        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Requisicao)base.SelecionarPorId(id);
        }


    }
}

