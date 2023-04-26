using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloFornecedor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloMedicamento
{
    public class Remedio : EntidadeBase
    {
        public string nome;
        public string descricao;
        public string lote;
        public DateTime validade;
        public int quantidade;
        public Fornecedor fornecedor;
        public int quantidadeRequisicoesSaida;


        public Remedio(string nome, string descricao, string lote, DateTime validade,Fornecedor fornecedor)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.lote = lote;
            this.validade = validade;          
            this.fornecedor = fornecedor;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Remedio remedioAtualizado = (Remedio)registroAtualizado;

            this.descricao = remedioAtualizado.descricao;
            this.nome = remedioAtualizado.nome;
            this.lote = remedioAtualizado.lote;
            this.validade = remedioAtualizado.validade;
            this.fornecedor = remedioAtualizado.fornecedor;
        }
        public void AdicionarQuantidade(int qtd)
        {
            this.quantidade += qtd;
        }

        public void RemoverQuantidade(int qtd)
        {
            quantidadeRequisicoesSaida++;
            this.quantidade -= qtd;
        }
    }
}
