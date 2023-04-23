using ControleDeRemedios.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloMedicamento
{
    public class RepositorioRemedio : Repositorio
    {     
       Tela tela = new Tela();
        
        public void HistoricoRemedios()
        {
        }

        public bool MostrarRemedios(bool v)
        {
            ArrayList listaRemedios = SelecionarTodos();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("{0,-10} | {1,-40} | {2,-30}", "ID", "Nome", "Quantidade");

            Console.WriteLine("---------------------------------------------------------------------------");

            foreach (Remedio r in listaRemedios)
            {
                Console.WriteLine("{0,-10} | {1,-40} | {2,-30}", r.id, r.nome, r.quantidade);
            }

            Console.ResetColor();

            return true;
        }
    
        public void Inserir(Remedio remedio)
        {
            listaregistros.Add(remedio);

            IncrementarId();

            IncrementarQuantidade();
        }
      
        public void IncrementarQuantidade()
        {
            quantidadeDeid++;
        }

        public void CadastrarRemedio()
        {
            TelaRemedio telaRemedio = new TelaRemedio();

            Remedio remedio = telaRemedio.ObterRemedio();
            
            Inserir(remedio);

            tela.ApresentarMensagem("Rémedio Inserido com sucesso!!", ConsoleColor.DarkGreen);

        }

        public void HistoricoDeRequisicao(Remedio remedio)
        {
            listaregistros.Add(remedio);

            foreach (Remedio item in listaregistros)
            {
                Console.WriteLine(item);
            }

        }
       
        public void EncherArrayBaixoEstoque(ArrayList arraybaixoestoque, ArrayList ListaRemedios)
        {
            foreach (Remedio item in ListaRemedios)
            {
                if (item.quantidade < 5)
                {
                    arraybaixoestoque.Add(item);
                }
            }
        }

        public void TirarDoBaixoEstoque(ArrayList arraybaixoestoque)
        {
            if (arraybaixoestoque == null)
            {
                return;
            }

            foreach (Remedio item in arraybaixoestoque)
            {
                if (item.quantidade >= 5)
                {
                    arraybaixoestoque.Remove(item);
                }
            }
        }

        public void MostrarRemediosBaixoEstoque()
        {

            ArrayList arraybaixoestoque = new ArrayList();
           
                Console.Clear();

            if (arraybaixoestoque == null)
            {
                tela.ApresentarMensagem("Nenhum remedio com baixo estoque", ConsoleColor.Green);
                Console.ReadLine();
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", "Id", "Nome", "Descricao", "Quantidade em Estoque");

            foreach (Remedio item in arraybaixoestoque)
            {
                Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", item.id, item.nome, item.descricao, item.quantidade);
            }

            finalMostrar();
        }

        public Remedio remedioMaisRetirado(ArrayList arrayRemedios)
        {
            int a = 0;
            Remedio remedio = null;

            foreach (Remedio item in arrayRemedios)
            {
                if (a < item.vezesRetirados)
                {
                    a = item.vezesRetirados;
                    remedio = item;
                }
            }
            return remedio;
        }

        public void MostrarRemedioMaisRetirado(ArrayList remediosCadastrados)
        {
            Remedio remedio = remedioMaisRetirado(remediosCadastrados);

            Console.WriteLine($"Remedio mais retirado:\n Nome: {remedio.nome}\n Id: {remedio.id} \n Descricao: {remedio.descricao}\n Quantidade de retiradas: {remedio.vezesRetirados}");
            finalMostrar();
        }

        private static void finalMostrar()
        {
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }

       

    }
}
