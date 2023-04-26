using ControleDeRemedios.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.ModuloMedicamento
{
    public class RepositorioRemedio : RepositorioBase
    {     
      
        public RepositorioRemedio(ArrayList listaRemedios) 
        {
             this.listaRegistros = listaRemedios;
        }

        public override Remedio SelecionarPorId(int id)
        {
            return (Remedio)base.SelecionarPorId(id);
        }

        public ArrayList SelecionarMedicamentosEmFalta()
        {
            ArrayList listaMedicamentosEmFalta = new ArrayList();

            foreach (Remedio r in listaRegistros)
            {
                if (r.quantidade == 0)
                    listaMedicamentosEmFalta.Add(r);
            }

            return listaMedicamentosEmFalta;
        }

        //public ArrayList SelecionarMedicamentosMaisRetirados()
        //{
        //    Remedio[] medicamentos = new Remedio[listaRegistros.Count];

        //    int posicao = 0;
        //    foreach (Remedio r in listaRegistros)
        //    {
        //        medicamentos[posicao++] = r;
        //    }

        //    Array.Sort(medicamentos, new ComparadorMedicamentosRetirados());

        //    return new ArrayList(medicamentos);
        //}




    }
}
