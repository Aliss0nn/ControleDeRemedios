using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloFornecedor;
using ControleDeRemedios.ModuloFuncionario;
using ControleDeRemedios.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloAquisicao
{
    public class RepositorioAquisicao : RepositorioBase
    {
        
       public RepositorioAquisicao(ArrayList listaAquisicao)
       {
         this.listaRegistros = listaAquisicao;
       }

        public override Aquisicao SelecionarPorId(int id)
        {
            return (Aquisicao)base.SelecionarPorId(id);
        }

    }
}
