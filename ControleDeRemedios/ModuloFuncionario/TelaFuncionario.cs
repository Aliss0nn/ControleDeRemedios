using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloPaciente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloFuncionario
{
    public class TelaFuncionario : RepositorioFuncionarios
    {
        public string MenuFuncionarios()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("[1] - Cadastrar novo Funcionário");
            Console.WriteLine("\n[2] - Visualizar Funcionários");
            Console.WriteLine("\n[3] - ");
            Console.WriteLine("\nPressione s para sair");

            string opcao = Console.ReadLine().ToUpper();

            return opcao;
        }

        public void CadastroDeFuncionarios(string opcaoFuncionario)
        {
            if (opcaoFuncionario == "1")
            {
                CadastrarFuncionarios();
            }
            else if (opcaoFuncionario == "2")
            {
                bool temremedio = VisualizarFuncionarios(true);

                if (temremedio)
                {
                    Console.ReadLine();
                }

            }
        }

        public bool VisualizarFuncionarios(bool v)
        {
            ArrayList listaDeFuncionarios = SelecionarTodos();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("{0,-10} | {1,-40} | {2,-30} | {3,-20}", "ID", "Nome", "CPF", "Telefone");

            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            foreach (Funcionario f in listaDeFuncionarios)
            {
                Console.WriteLine("{0,-10} | {1,-40} | {2,-30} | {3,-20}", f.id, f.nome, f.cpf, f.telefoneFuncionario) ;
            }

            Console.ResetColor();

            return true;
        }


        public void CadastrarFuncionarios()
        {
            Funcionario funcionario = ObterFuncionarios();

            Inserir(funcionario);

            IncrementarId();
        }

          
        public Funcionario ObterFuncionarios()
        {
            
           Funcionario funcionario = new Funcionario();           
           Console.Clear();
           Console.WriteLine();

           Console.Write("Digite o nome do Funcionário: ");
           string nome = Console.ReadLine();

            Console.Write("\nDigite o CPF do Funcionário: ");
            int cpf = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o Telefone do Funcionário: ");
            int numero = int.Parse(Console.ReadLine());

            funcionario.nome = nome;
            funcionario.cpf = cpf;
            funcionario.telefoneFuncionario = numero;
            funcionario.id = id;

            return funcionario;

        }









    }

}
