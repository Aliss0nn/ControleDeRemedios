using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloFuncionario;
using ControleDeRemedios.ModuloMedicamento;
using ControleDeRemedios.ModuloPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloRequisicao
{
    public class Requisicao : Entidade
    {

        public Paciente paciente;
        public Remedio remedio;
        public Funcionario funcionario;
        public DateTime data;
        public int quantidadeMedicamento;


        public Requisicao() { }

        public Requisicao(Paciente paciente, Remedio remedio, Funcionario funcionario, DateTime date, int quantidadeMedicamento)
        {

            this.paciente = paciente;
            this.remedio = remedio;
            this.funcionario = funcionario;
            this.data = date;
            this.quantidadeMedicamento = quantidadeMedicamento;
        }


    }
}
