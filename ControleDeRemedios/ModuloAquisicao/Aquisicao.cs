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
    public class Aquisicao : EntidadeBase
    {

        public Remedio remedio;
        public int quantidade;
        public DateTime data;
        public Funcionario funcionario;

        public Aquisicao(Remedio remedio, int quantidade, DateTime data, Funcionario funcionario)
        {
            this.remedio = remedio;
            this.quantidade = quantidade;
            this.data = data;
            this.funcionario = funcionario;

            this.remedio.AdicionarQuantidade(quantidade);
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Aquisicao aquisicaoAtualizada = (Aquisicao)registroAtualizado;

            this.data = aquisicaoAtualizada.data;
            this.funcionario = aquisicaoAtualizada.funcionario;
            this.remedio = aquisicaoAtualizada.remedio;
            this.quantidade = aquisicaoAtualizada.quantidade;
        }

        public void DesfazerRegistro()
        {

            remedio.RemoverQuantidade(quantidade);
        }
    }
}
