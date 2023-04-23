using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloFornecedor;
using ControleDeRemedios.ModuloFuncionario;
using ControleDeRemedios.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloAquisicao
{
    public class RepositorioAquisicao
    {
        Tela tela = new Tela();
        TelaAquisicao telaAquisicao = new TelaAquisicao();
        TelaRemedio telaRemedio = new TelaRemedio();
        public void FazerAquisicao(ArrayList remediosCadastados, ArrayList Fornecedores, ArrayList listaFuncionarios, ArrayList RemediosBaixoEstoque)
        {
            if (VerificarSeExiste(remediosCadastados, Fornecedores, listaFuncionarios))
                return;

            Remedio remedio = telaAquisicao.PegarValorRemedio();

            int idFornecedor = BuscarFornecedor(remedio, Fornecedores);

            if (VeriricarId(idFornecedor))
            {
                Console.Clear();
                return;
            }

            //Fornecedor fornecedor = (Fornecedor)(Fornecedores, idFornecedor);

            Console.Clear();

            Funcionario funcionario = telaAquisicao.PegarValorFuncionario();

            Console.Clear();

            DateTime date = DateTime.Today;
            int quantidade = tela.PegarInformacao("Qual a quantidade de medicamento deseja adicionar ao estoque?");
            remedio.quantidade += quantidade;

            Console.Clear();

            //var aquisicao = new Aquisicao(fornecedor, remedio, funcionario, date, quantidade);
            //AdicionarArray(Aquisicao, aquisicao);

            telaRemedio.TirarDoBaixoEstoque(RemediosBaixoEstoque);
            tela.ApresentarMensagem("Aquisicao feita com sucesso!", ConsoleColor.Green);
        }

        private int BuscarFornecedor(Remedio remedio, ArrayList Fornecedores)
        {
            int id = 0;

            foreach (Fornecedor item in Fornecedores)
            {
                if (item.nome.Contains(remedio.nome))
                {
                    id = item.id;
                    return id;
                }
            }
            return 404;
        }

        private bool VeriricarId(int idFornecedor)
        {
            if (idFornecedor == 404)
            {
                tela.ApresentarMensagem("Nenhum Fornecedorr cadastrado forncesse esse medicamento!", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            return false;
        }

        private bool VerificarSeExiste(ArrayList remedios, ArrayList fornecedores, ArrayList funcionarios)
        {
            if (remedios.Count <= 0)
            {
                tela.ApresentarMensagem("Nenhum Remedio cadastrado! ", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return true;
            }

            else if (fornecedores.Count <= 0)
            {

                tela.ApresentarMensagem("Nenhum Fornecedor cadastrado! ", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return true;
            }

            else if (funcionarios.Count <= 0)
            {

                tela.ApresentarMensagem("Nenhum funcionario cadastrado! ", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return true;
            }

            return false;
        }


























    }
}
