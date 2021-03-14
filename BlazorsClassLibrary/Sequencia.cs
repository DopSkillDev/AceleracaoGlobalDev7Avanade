using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorsClassLibrary
{
    public class Sequencia
    {
        public int[] GetLista(int[] numero)
        {
            int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            numero = lista;

            return numero;    
        }

        public string GetMensagem()
        {
            return "Está é um teste de instância com o Blazors";
        }
    }
}
