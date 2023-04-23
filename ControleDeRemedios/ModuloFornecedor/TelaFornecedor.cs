using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloFornecedor
{
    public class TelaFornecedor : RepositorioFornecedor
    {
        public string MenuFornecedor()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("[1] - Cadastrar novo Fornecedor");
            Console.WriteLine("\n[2] - Visualizar os Fornecedores");
            Console.WriteLine("\n[3] - ");
            Console.WriteLine("\nPressione s para sair");

            string opcao = Console.ReadLine().ToUpper();

            return opcao;
        }

        public void CadastroFornec(string opcaoFornecedor)
        {
            if (opcaoFornecedor == "1")
            {
                CadastrarFornecedor();
            }
            else if (opcaoFornecedor == "2")
            {
                bool temremedio = VisualizarFornecedores(true);

                if (temremedio)
                {
                    Console.ReadLine();
                }

            }
            //else if (opcaoCadastro == "3")
            //{
            //    HistoricoRemedios();
            //}

        }

        public bool VisualizarFornecedores(bool v)
        {
            ArrayList listaFornecedores = SelecionarTodos();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("{0,-10} | {1,-40} | {2,-30} | {3,-20}", "ID", "Nome", "CNPJ" , "Email");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------");

            foreach (Fornecedor f in listaFornecedores)
            {
                Console.WriteLine("{0,-10} | {1,-40} | {2,-30} | {3,-20}", f.id, f.nome, f.cnpj, f.email);                   
            }

            Console.ResetColor();

            return true;
        }

        public void CadastrarFornecedor()
        {
            Fornecedor fornecedor = ObterFornecedor();

            Inserir(fornecedor);

            IncrementarId();
        }

        public Fornecedor ObterFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor();
            Console.Clear();
            Console.Write("Digite o nome do Fornecedor: ");
            string nome = Console.ReadLine();

            Console.Write("\nDigite o CNPJ do Fornecedor: ");
            int cnpj = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o Telefone do Fornecedor: ");
            int telefone = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o email do Fornecedor: ");
            string email = Console.ReadLine(); 
            



            fornecedor.nome = nome;
            fornecedor.cnpj = cnpj;
            fornecedor.telefoneFornecedor = telefone;
            fornecedor.email = email;
            fornecedor.id = id;


            return fornecedor;
        }
    }
}
