using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloFornecedor;
using ControleDeRemedios.ModuloFuncionario;
using ControleDeRemedios.ModuloMedicamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloAquisicao
{
    public class Aquisicao : Entidade
    {

        public Fornecedor fornecedor { get; set; }
        public Remedio remedio { get; set; }
        public Funcionario funcionario { get; set; }
        public DateTime data { get; set; }
        public int quantidadeMedicamento { get; set; }

        public Aquisicao()
        {

        }

        public Aquisicao(Fornecedor fornecedor, Remedio remedio, Funcionario funcionario, DateTime date, int quantidadeMedicamento)
        {

        }



    }
}
