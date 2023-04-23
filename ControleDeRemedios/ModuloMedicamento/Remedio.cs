using ControleDeRemedios.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloMedicamento
{
    public class Remedio : Tela
    {
        

        //public ArrayList listaRemedios = new ArrayList();
        //public ArrayList requisicoes = new ArrayList();
        public string nome = "";
        public string descricao = "";
        public int id;
        public int ContadorDeId = 1;
        public int quantidade { get; set; }
        public int quantidadeMinima { get; set; }
        public int vezesRetirados = 0;


        public void VerificarQuantidadeRemedio()
        {
            if (quantidade < quantidadeMinima)
            {
                ApresentarMensagem("Quantidade de remedio abaixo do necessario!", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }

            else if (quantidade == 0)
            {
                ApresentarMensagem("O remedio acabou no estoque!", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }
        }


        //public Remedio(int id, string nome, string descricao, int quantidade, int quantidadeMinima)
        //{
        //    this.nome = nome;
        //    this.descricao = descricao;
        //    this.quantidade = quantidade;
        //    this.quantidadeMinima = quantidadeMinima;
        //}















    }
}
