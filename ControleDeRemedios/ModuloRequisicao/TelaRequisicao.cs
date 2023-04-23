using ControleDeRemedios.Compartilhado;
using ControleDeRemedios.ModuloFuncionario;
using ControleDeRemedios.ModuloMedicamento;
using ControleDeRemedios.ModuloPaciente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloRequisicao
{
    public class TelaRequisicao : Tela
    {

        Repositorio repositorio = new Repositorio();
        public Paciente PegarPaciente(ArrayList pacientes)
        {
            //telaPaciente.MostrarPacientes(pacientes);

            MostrarObjetos<Paciente>(pacientes,repositorio.camposPacientes);
            int idPaciente = PegarOpcaoId("Qual o id do paciente");
            Paciente paciente = (Paciente)repositorio.SelecionarPorId(id);
            return paciente;
        }

        public Remedio PegarRemedio(ArrayList remediosCadastados)
        {
            //telaRemedio.MostrarRemedios(remediosCadastados);
            MostrarObjetos<Remedio>(remediosCadastados, repositorio.camposRemedio);
            int idRemedio = PegarOpcaoId("Qual o id do remedio?");
            Remedio remedio = (Remedio)repositorio.SelecionarPorId(id);
            return remedio;
        }

        public int PegarQuantidadeRemedio()
        {
            ApresentarMensagem("Qual a quantidade de remedios?", ConsoleColor.White);
            int quantidadeRemedio = int.Parse(Console.ReadLine());
            return quantidadeRemedio;
        }

        public Funcionario PegarInformacoesFuncionario(ArrayList listaFuncionarios)
        {
            // telaFuncionario.MostrarFuncionarios(listaFuncionarios);
            MostrarObjetos<Funcionario>(listaFuncionarios, repositorio.camposFuncionarios);
            int idFunc = PegarOpcaoId("Qual o id do funcionario?");
            Funcionario funcionario = (Funcionario)repositorio.SelecionarPorId(id);

            return funcionario;
        }










    }
}
