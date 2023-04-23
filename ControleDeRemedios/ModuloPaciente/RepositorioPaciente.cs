using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloPaciente
{

    public class RepositorioPaciente : Repositorio
    {
        Tela tela = new Tela();   
        
        
        public string MenuPaciente()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("[1] - Cadastrar novo paciente");
            Console.WriteLine("\n[2] - Visualizar Pacientes");
            Console.WriteLine("\n[3] - ");
            Console.WriteLine("\nPressione s para sair");

            string opcao = Console.ReadLine().ToUpper();

            return opcao;
        }

        public void CadastroDePacientes(string opcaoPaciente)
        {
            if (opcaoPaciente == "1")
            {
                CadastrarPacientes();
            }
            else if (opcaoPaciente == "2")
            {
                bool temremedio = VisualizarPacientes(true);

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

        public bool VisualizarPacientes(bool v)
        {

            ArrayList listaPacientes = SelecionarTodos();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("{0,-10} | {1,-40} | {2,-30} | {3,-20}" , "ID", "Nome", "CPF" , "Telefone");

            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            foreach (Paciente p in listaPacientes)
            {
                Console.WriteLine("{0,-10} | {1,-40} | {2,-30} | {3,-20}", p.id, p.nome, p.cpf, p.telefone);
            }

            Console.ResetColor();

            return true;       

        }

        public Paciente ObterPacientes()
        {
            Paciente paciente = new Paciente();
            Console.Clear();
            Console.WriteLine();

            Console.Write("Digite o nome do Paciente: ");
            string nome = Console.ReadLine();

            Console.Write("\nDigite o CPF do Paciente: ");
            int cpf = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o número do Cartão SUS: ");
            int cartaoSUS = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o telefone do Paciente: ");
            int numeroTelefone = int.Parse(Console.ReadLine());

            paciente.nome = nome;
            paciente.cartaoSUS = cartaoSUS;
            paciente.telefone = numeroTelefone;
            paciente.cpf = cpf;

            return paciente;

        }

        public void CadastrarPacientes()
        {
          
            Paciente paciente = ObterPacientes();
            
            Inserir(paciente);

            tela.ApresentarMensagem("Paciente Inserido com sucesso!!", ConsoleColor.DarkGreen);

        }
        
       

















    }

}
