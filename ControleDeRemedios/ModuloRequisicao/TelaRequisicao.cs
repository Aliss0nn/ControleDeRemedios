using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloFuncionario;
using ControleDeRemedios.ModuloMedicamento;
using ControleDeRemedios.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloRequisicao
{
    public class TelaRequisicao : TelaBase
    {
       
        RequisicaoRepositorio repositorioRequisicao;
        RepositorioRemedio repositorioRemedio;
        RepositorioFuncionario repositorioFuncionario;
        RepositorioPaciente repositorioPaciente;

        TelaRemedio telaRemedio;
        TelaFuncionario telaFuncionario;
        TelaPaciente telaPaciente;

        public TelaRequisicao(RepositorioRemedio repositorioRemedio, RepositorioFuncionario repositorioFuncionario, 
            RepositorioPaciente repositorioPaciente, TelaRemedio telaRemedio,
            TelaFuncionario telaFuncionario, TelaPaciente telaPaciente , RequisicaoRepositorio requisicaoRepositorio)
        {
            this.repositorioBase = requisicaoRepositorio;
            this.repositorioRemedio = repositorioRemedio;
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioPaciente = repositorioPaciente;
            this.telaRemedio = telaRemedio;
            this.telaFuncionario = telaFuncionario;
            this.telaPaciente = telaPaciente;

            nomeEntidade = "Requisição";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            const string FORMATO_TABELA = "{0, -10} | {1, -10} | {2, -20} | {3, -20} | {4, -20} | {5, -20}";

            Console.WriteLine(FORMATO_TABELA, "Id", "Data", "Medicamento", "Fonecedor", "Paciente", "Quantidade");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Requisicao requisicao in registros)
            {
                Console.WriteLine(FORMATO_TABELA,
                    requisicao.id,
                    requisicao.data.ToShortDateString(),
                    requisicao.remedio.nome,
                    requisicao.remedio.fornecedor.nome,
                    requisicao.paciente.nome,
                    requisicao.quantidade);
            }
        }

        public override void EditarRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}{sufixo}", "Editando um registro já cadastrado...");

            VisualizarRegistros(false);

            Console.WriteLine();

            Console.Write("Digite o id do registro: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Requisicao requisicao = (Requisicao)repositorioFuncionario.SelecionarPorId(id);

            EntidadeBase registroAtualizado = ObterRegistro();

            requisicao.DesfazerRegistroSaida();

            repositorioBase.Editar(id, registroAtualizado);

            MostrarMensagem("Registro editado com sucesso!", ConsoleColor.Green);
        }

        public override void ExcluirRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}{sufixo}", "Excluindo um registro já cadastrado...");

            VisualizarRegistros(false);

            Console.WriteLine();

            Console.Write("Digite o id do registro: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Requisicao requisicao = (Requisicao)repositorioRequisicao.SelecionarPorId(id);

            requisicao.DesfazerRegistroSaida();

            repositorioBase.Excluir(id);

            MostrarMensagem("Registro excluído com sucesso!", ConsoleColor.Green);
        }

        protected override EntidadeBase ObterRegistro()
        {
            Remedio remedio = ObterRemedio();

            Funcionario funcionario = ObterFuncionario();

            Paciente paciente = ObterPaciente();

            Console.Write("Digite a quantidade de caixas: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a data: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            return new Requisicao(remedio, quantidade, data, funcionario, paciente);

        }

        private Paciente ObterPaciente()
        {
            telaPaciente.VisualizarRegistros(false);
          
            Console.Write("\nDigite o id do Funcionário: ");
            int idPaciente = Convert.ToInt32(Console.ReadLine());
           
            Paciente paciente = (Paciente)repositorioPaciente.SelecionarPorId(idPaciente);

            Console.WriteLine();

            return paciente;
        }

        private Funcionario ObterFuncionario()
        {
            telaFuncionario.VisualizarRegistros(false);
          
            Console.Write("\nDigite o id do Funcionário: ");
            int idFuncionario = Convert.ToInt32(Console.ReadLine());
          
            Funcionario funcionario = (Funcionario)repositorioFuncionario.SelecionarPorId(idFuncionario);

            Console.WriteLine();

            return funcionario;
        }

        private Remedio ObterRemedio()
        {           
            telaRemedio.VisualizarRegistros(false);
            
            Console.Write("\nDigite o id do Medicamento: ");
            int idMedicamento = Convert.ToInt32(Console.ReadLine());
          
            Remedio remedio = repositorioRemedio.SelecionarPorId(idMedicamento);

            Console.WriteLine();

            return remedio;
        }
    }
}
        
    

