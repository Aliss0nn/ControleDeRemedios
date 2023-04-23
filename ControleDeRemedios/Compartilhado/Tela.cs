using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeRemedios.Compartilhado
{
    public class Tela : Repositorio
    {
        public void ApresentarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.WriteLine();
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }

        public int PegarOpcaoId(string mensagem)
        {
            ApresentarMensagem(mensagem, ConsoleColor.Blue);
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public int PegarInformacao(string mensagem)
        {
            ApresentarMensagem(mensagem, ConsoleColor.Blue);
            int item = int.Parse(Console.ReadLine());

            return item;


        }

        public void MostrarObjetos<T>(ArrayList array, string[] campos)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            foreach (string campo in campos)
            {
                Console.Write("|{0,-15}", campo);
            }

            Console.WriteLine();

            foreach (T item in array)
            {
                foreach (string campo in campos)
                {
                    object valor = item.GetType().GetProperty(campo).GetValue(item, null);

                    if (valor is int)
                    {
                        valor = valor.ToString();
                    }

                    Console.Write("|{0,-15}", valor.ToString());
                }

                Console.WriteLine();
            }
            Console.ResetColor();
        }

    }
}
