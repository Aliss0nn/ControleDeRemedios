using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloFuncionario;
using ControleDeRemedios.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeRemedios.ModuloAquisicao
{
    public class TelaAquisicao : TelaBase
    {
        private RepositorioAquisicao repositorioAquisicao;

        private RepositorioFuncionario repositorioFuncionario;
        private RepositorioRemedio repositorioRemedio;

        private TelaFuncionario telaFuncionario;
        private TelaRemedio telaRemedio;

        public TelaAquisicao(RepositorioAquisicao repositorioAquisicao, RepositorioFuncionario repositorioFuncionarios,
            RepositorioRemedio repositorioRemedio, TelaFuncionario telaFuncionario, TelaRemedio telaRemedio)
        {
            this.repositorioBase = repositorioAquisicao;
            
            this.repositorioAquisicao = repositorioAquisicao;
            this.repositorioFuncionario = repositorioFuncionarios;
            this.repositorioRemedio = repositorioRemedio;
            this.telaFuncionario = telaFuncionario;
            this.telaRemedio = telaRemedio;

            nomeEntidade = "Aquisição";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            throw new NotImplementedException();
        }

        protected override EntidadeBase ObterRegistro()
        {
            Remedio remedio = ObterMedicamento();

            Funcionario funcionario = ObterFuncionario();

            Console.Write("Digite a quantidade de caixas: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a data: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            return new Aquisicao(remedio, quantidade, data, funcionario);
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

        private Remedio ObterMedicamento()
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
