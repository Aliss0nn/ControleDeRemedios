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
            RepositorioFornecedor repositorioFornecedor = new RepositorioFornecedor(new ArrayList());
            RepositorioRemedio repositorioRemedio = new RepositorioRemedio(new ArrayList());
            RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario(new ArrayList());
            RepositorioPaciente repositorioPaciente = new RepositorioPaciente(new ArrayList());
            RepositorioAquisicao repositorioAquisicao = new RepositorioAquisicao(new ArrayList());
            RequisicaoRepositorio requisicaoRepositorio = new RequisicaoRepositorio(new ArrayList());

            TelaFornecedor telaFornecedor = new TelaFornecedor(repositorioFornecedor);
            TelaRemedio telaRemedio = new TelaRemedio(repositorioRemedio, telaFornecedor, repositorioFornecedor);
            TelaFuncionario telaFuncionario = new TelaFuncionario(repositorioFuncionario);
            TelaPaciente telaPaciente = new TelaPaciente(repositorioPaciente);
            TelaAquisicao telaAquisicao = new TelaAquisicao(repositorioAquisicao, repositorioFuncionario, repositorioRemedio, telaFuncionario, telaRemedio);
            TelaRequisicao telaRequisicao = new TelaRequisicao(repositorioRemedio, repositorioFuncionario, repositorioPaciente, telaRemedio, telaFuncionario, telaPaciente, requisicaoRepositorio);
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            #endregion

            //Console.Clear();
            //Console.WriteLine();

            //Console.WriteLine("[1] - Menu dos Rémedios");
            //Console.WriteLine("[2] - Menu dos Pacientes");
            //Console.WriteLine("[3] - Menu dos Fornecedores");
            //Console.WriteLine("[4] - Menu dos Funcionários");
            //Console.WriteLine("[5] - Cadastrar Requisições");
            //Console.WriteLine("[6] - Fazer uma Aquisição");
            //Console.WriteLine("[7] Ver remedios com baixo estoque");
            //Console.WriteLine("[8] Ver remedios com maior frequencia de saida!");

            while (true)
            {
                string opcao = telaPrincipal.ApresentarMenu();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string subMenu = telaFornecedor.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaFornecedor.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaFornecedor.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaFornecedor.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaFornecedor.ExcluirRegistro();
                    }
                }
                else if (opcao == "2")
                {
                    string subMenu = telaFuncionario.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaFuncionario.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaFuncionario.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaFuncionario.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaFuncionario.ExcluirRegistro();
                    }
                }
                else if (opcao == "3")
                {
                    string subMenu = telaPaciente.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaPaciente.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaPaciente.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaPaciente.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaPaciente.ExcluirRegistro();
                    }
                }
                else if (opcao == "4")
                {
                    string subMenu = telaRemedio.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaRemedio.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaRemedio.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaRemedio.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaRemedio.ExcluirRegistro();
                    }
                    //else if (subMenu == "5")
                    //{
                    //    telaRemedio.VisualizarMedicamentosMaisRetirados();
                    //    Console.ReadLine();
                    //}
                    //else if (subMenu == "6")
                    //{
                    //    telaRemedio.VisulizarMedicamentosEmFalta();
                    //    Console.ReadLine();
                    //}
                }
                else if (opcao == "5")
                {
                    string subMenu = telaRequisicao.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaRequisicao.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaRequisicao.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaRequisicao.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaRequisicao.ExcluirRegistro();
                    }
                }
                else if (opcao == "6")
                {
                    string subMenu = telaAquisicao.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaAquisicao.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaAquisicao.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaAquisicao.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaAquisicao.ExcluirRegistro();
                    }   
                }
            }
        }
    }
}







