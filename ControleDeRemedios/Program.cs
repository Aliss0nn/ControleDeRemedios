using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloAquisicao;
using ControleDeRemedios.ModuloFornecedor;
using ControleDeRemedios.ModuloFuncionario;
using ControleDeRemedios.ModuloMedicamento;
using ControleDeRemedios.ModuloPaciente;
using ControleDeRemedios.ModuloRequisicao;
using System;
using System.Collections;

namespace ControleDeRemedios
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region  
            RepositorioRemedio repositorioRemedio = new RepositorioRemedio();
          
            RepositorioPaciente repositoriopaciente = new RepositorioPaciente();
            
            TelaRemedio telaRemedio = new TelaRemedio();
            TelaFornecedor telaFornecedor = new TelaFornecedor();
            RepositorioFornecedor repositorioFornecedor = new RepositorioFornecedor();
            RepositorioFuncionarios repositorioFuncionarios = new RepositorioFuncionarios();
            TelaFuncionario telaFuncionario = new TelaFuncionario();
            ArrayList remediosCadastrados = new ArrayList();
           
            RepositorioAquisicao repositorioAquisicao = new RepositorioAquisicao();
            RequisicaoRepositorio requisicaoRepositorio = new RequisicaoRepositorio();
            #endregion

            while (true)
            {

                Console.Clear();
                Console.WriteLine();

                Console.WriteLine("[1] - Menu dos Rémedios");
                Console.WriteLine("[2] - Menu dos Pacientes");
                Console.WriteLine("[3] - Menu dos Fornecedores");
                Console.WriteLine("[4] - Menu dos Funcionários");
                Console.WriteLine("[5] - Cadastrar Requisições");
                Console.WriteLine("[6] - Fazer uma Aquisição");
                Console.WriteLine("[7] Ver remedios com baixo estoque");
                Console.WriteLine("[8] Ver remedios com maior frequencia de saida!");


                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        string opcaoCadastro = telaRemedio.MenuRemedios();
                        telaRemedio.CadastroDeRemedios(opcaoCadastro);
                        break;

                    case "2":
                        string opcaoPaciente = repositoriopaciente.MenuPaciente();
                        repositoriopaciente.CadastroDePacientes(opcaoPaciente);
                        break;

                   case "3":
                        string opcaoFornecedor = telaFornecedor.MenuFornecedor();
                        telaFornecedor.CadastroFornec(opcaoFornecedor);
                        break;
                    
                   case "4":
                        string opcaoFuncionario = telaFuncionario.MenuFuncionarios();
                        telaFuncionario.CadastroDeFuncionarios(opcaoFuncionario);
                        break;
                    
                    case "5":
                        Console.Clear();
                        requisicaoRepositorio.FazerRequisicao(repositorioFuncionarios.listaregistros, repositoriopaciente.listaregistros, repositorioRemedio.listaregistros, repositorioFornecedor.listaregistros , repositorioRemedio.listaregistros);
                        break;

                    case "6":
                        Console.Clear();
                        repositorioAquisicao.FazerAquisicao(repositorioRemedio.listaregistros, repositorioFornecedor.listaregistros, repositorioFuncionarios.listaregistros, repositorioRemedio.listaregistros);
                        break;

                    case "7":
                        Console.Clear();
                        telaRemedio.MostrarRemediosBaixoEstoque();
                        break;
                    
                    case "8":
                        Console.Clear();
                        telaRemedio.MostrarRemedioMaisRetirado(remediosCadastrados);
                        break;






                }















            }



















        }
































    }














































}
