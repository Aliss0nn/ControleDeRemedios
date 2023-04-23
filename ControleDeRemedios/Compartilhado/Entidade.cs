using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.Compartilhado
{
    public class Entidade
    {
        public int id;

        public virtual void Atualizar(Entidade registroAtualizado)
        {
            id = registroAtualizado.id;
        }
    }
}
