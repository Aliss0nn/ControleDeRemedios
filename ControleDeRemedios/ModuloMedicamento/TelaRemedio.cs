using ControleDeRemedios.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloMedicamento
{
    public class TelaRemedio : RepositorioRemedio
    {
        Tela tela = new Tela();    
       
        public string MenuRemedios()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("[1] - Cadastrar novo rémedio");
            Console.WriteLine("\n[2] - Verificar quantidade de rémedios");
            Console.WriteLine("\n[3] - Editar os Rémedios");
            Console.WriteLine("\n[4] - Excluir os Rémedios");              
            Console.WriteLine("\nPressione s para sair");

            string opcao = Console.ReadLine().ToUpper();

            return opcao;
        }

        public void CadastroDeRemedios(string opcaoCadastro)
        {
            if (opcaoCadastro == "1")
            {
                CadastrarRemedio();
            }
            else if (opcaoCadastro == "2")
            {
                bool temremedio = MostrarRemedios(true);

                if (temremedio)
                {
                    Console.ReadLine();
                }

            }
            else if (opcaoCadastro == "3")
            {
                EditarRemedio();
            }
            else if (opcaoCadastro == "4")
            {
                ExcluirRemedios();
            }


        }

        private void EditarRemedio()
        {
            bool temremedio = MostrarRemedios(true);

            if (temremedio == false)
                return;

            Console.WriteLine();

            int idSelecionado = EncontrarRemedio();

            Remedio remedioAtualizado = ObterRemedio();

            RepositorioRemedio repositorioRemedio = new RepositorioRemedio();

            repositorioRemedio.Editar(idSelecionado, remedioAtualizado);

            tela.ApresentarMensagem("Remédio editado com sucesso!", ConsoleColor.White);
        }

        private int EncontrarRemedio()
        {
            int idSelecionado;
            bool idInvalido;

            do
            {
                Console.Write("Digite o Id do Rémedio: ");

                idSelecionado = Convert.ToInt32(Console.ReadLine());

                RepositorioRemedio repositorioRemedio = new RepositorioRemedio();

                idInvalido = repositorioRemedio.SelecionarPorId(idSelecionado) == null;

                if (idInvalido)
                    tela.ApresentarMensagem("Id inválido, tente novamente", ConsoleColor.Red);

            } while (idInvalido);

            return idSelecionado;
        }

        public Remedio ObterRemedio()
        {
            Remedio remedio = new Remedio();
            Console.Clear();
            Console.Write("Digite o nome do Rémedio: ");
            string nome = Console.ReadLine();

            Console.Write("\nDescrição do rémedio: ");
            string descricao = Console.ReadLine();

            Console.Write("\nEscolha o id do rémedio: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a quantidade do Rémedio");
            int quantidade = int.Parse(Console.ReadLine());

            remedio.nome = nome;
            remedio.descricao = descricao;
            remedio.id = id;
            remedio.quantidade = quantidade;


            return remedio;
        }

        public void ExcluirRemedios()
        {

            bool temEquipamentosGravados = MostrarRemedios(true);

            if (temEquipamentosGravados == false)
                return;

            Console.WriteLine();

            int idSelecionado = EncontrarRemedio();

            RepositorioRemedio repositorioRemedio = new RepositorioRemedio();

            repositorioRemedio.Excluir(idSelecionado);

            tela.ApresentarMensagem("Rémedio excluído com sucesso!", ConsoleColor.Green);

        }
    }
}
