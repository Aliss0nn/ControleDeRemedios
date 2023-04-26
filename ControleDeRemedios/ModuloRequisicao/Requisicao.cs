using ControleDeRemedios.Compartilhado;
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
    public class Requisicao : EntidadeBase
    {
        public Remedio remedio;
        public int quantidade;
        public DateTime data;
        public Funcionario funcionario;
        public Paciente paciente;
        public Requisicao(Remedio remedio, int quantidade, DateTime data, Funcionario funcionario , Paciente paciente)
        {
            this.remedio = remedio;
            this.quantidade = quantidade;
            this.data = data;
            this.funcionario = funcionario;
            this.paciente = paciente;

            this.remedio.AdicionarQuantidade(quantidade);
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Requisicao requisicaoAtualizada = (Requisicao)registroAtualizado;

            this.remedio = requisicaoAtualizada.remedio;
            this.quantidade = requisicaoAtualizada.quantidade;
            this.data = requisicaoAtualizada.data;
            this.funcionario = requisicaoAtualizada.funcionario;
            this.paciente = requisicaoAtualizada .paciente;
        }

        public void DesfazerRegistroSaida()
        {
            remedio.AdicionarQuantidade(quantidade);
        }

    }
}
