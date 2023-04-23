using ControleDeRemedios.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.Compartilhado
{
    public class Repositorio : Entidade
    {      
        
        public int quantidadeDeid = 1;
        public int contadorDeId = 1;
        public string[] camposRemedio = { "id", "nome", "descricao", "quantidade", "quantidadeMinima" };
        public string[] camposFuncionarios = { "id", "nome", "cpf" };
        public string[] camposPacientes = { "id", "nome", "cpf", "cartaoSus", "telefone" };


        public ArrayList listaregistros = new ArrayList();

        public void Inserir(Entidade registro)
        {
            listaregistros.Add(registro);

            IncrementarId();
        }

        public void IncrementarId()
        {
            contadorDeId++;
        }

        public void Editar(int id, Entidade registroAtualizado)
        {
            Entidade registro = SelecionarPorId(id);

            registro.Atualizar(registroAtualizado);

        }

        public Entidade SelecionarPorId(int id)
        {
            Entidade registro = null;


            foreach (Entidade r in listaregistros)
            {
                if (r.id == id)
                {
                    registro = r;
                    break;
                }
            }

            return registro;

        }

        public ArrayList SelecionarTodos()
        {
            return listaregistros;
        }

        public void Excluir(int id)
        {
            Entidade registro = SelecionarPorId(id);

            listaregistros.Remove(registro);
        }
       
       
    }
}
