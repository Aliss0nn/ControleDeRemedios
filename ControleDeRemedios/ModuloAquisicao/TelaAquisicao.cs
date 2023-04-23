using ControleDeRemedios.Compartilhado;
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
    public class TelaAquisicao : Tela
    {
        TelaRemedio telaRemedio = new TelaRemedio();
        Repositorio repositorio = new Repositorio();
        TelaFuncionario Telafuncionario = new TelaFuncionario();
        
        public Remedio PegarValorRemedio()
        {
            telaRemedio.MostrarRemedios(true);
            int id = PegarInformacao("Qual o id do medicamento deseja adquirir? ");
            Remedio remedio = (Remedio)repositorio.SelecionarPorId(id);

            return remedio;
        }

        public Funcionario PegarValorFuncionario()
        {
            Telafuncionario.VisualizarFuncionarios(true);
            int id = PegarInformacao("Qual o id do funcionario fazendo a Aquisicao?");
            Funcionario funcionario = (Funcionario)repositorio.SelecionarPorId(id);

            return funcionario;
        }










    }
}
