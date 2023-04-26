using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloMedicamento
{
    public class TelaRemedio : TelaBase
    {
       
        private RepositorioFornecedor repositorioFornecedor;            
        private TelaFornecedor telaFornecedor;
        private RepositorioRemedio repositorioRemedio;

        public TelaRemedio(RepositorioRemedio repositorioRemedio,
           TelaFornecedor telaFornecedor, RepositorioFornecedor repositorioFornecedor)
        {
            this.repositorioBase = repositorioRemedio;
            this.repositorioRemedio = repositorioRemedio;
            this.telaFornecedor = telaFornecedor;
            this.repositorioFornecedor = repositorioFornecedor;

            nomeEntidade = "Medicamento";
            sufixo = "s";
        }

        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Medicamentos \n");

            Console.WriteLine("Digite 1 para Inserir Medicamento");
            Console.WriteLine("Digite 2 para Visualizar Medicamentos");
            Console.WriteLine("Digite 3 para Editar Medicamentos");
            Console.WriteLine("Digite 4 para Excluir Medicamentos");
            Console.WriteLine("Digite 5 para Visualizar Medicamentos Mais Retirados");
            Console.WriteLine("Digite 6 para Visualizar Medicamentos em Falta\n");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }


        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20} | {4, -20}", "Id", "Nome", "Fornecedor", "Quantidade", "Qtd Retiradas");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach (Remedio remedio in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20} | {4, -20}",
                    remedio.id, remedio.nome, remedio.fornecedor.nome, remedio.quantidade, remedio.quantidadeRequisicoesSaida);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Fornecedor fornecedor = ObterFornecedor();

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Digite o lote: ");
            string lote = Console.ReadLine();

            Console.Write("Digite a data de validade: ");
            DateTime dataValidade = DateTime.Parse(Console.ReadLine());

            return new Remedio(nome, descricao, lote, dataValidade, fornecedor);
        }

        private Fornecedor ObterFornecedor()
        {
            telaFornecedor.VisualizarRegistros(false);

            Console.Write("\nDigite o id do Forncedor: ");
            int idFornecedor = Convert.ToInt32(Console.ReadLine());

            Fornecedor fornecedor = repositorioFornecedor.SelecionarPorId(idFornecedor);

            Console.WriteLine();

            return fornecedor;
        }
    }
}
