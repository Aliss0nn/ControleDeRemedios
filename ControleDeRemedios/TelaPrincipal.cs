using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Controle de Medicamentos \n");

            Console.WriteLine("[1] - para Cadastrar Fornecedores");
            Console.WriteLine("[2] - para Cadastrar Funcionários");
            Console.WriteLine("[3] - para Cadastrar Pacientes");
            Console.WriteLine("[4] - para Cadastrar Medicamentos");

            Console.WriteLine("[5] - para Cadastrar Requisições de Entrada");
            Console.WriteLine("[6] - para Cadastrar Requisições de Saída\n");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
