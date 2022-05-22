using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Helper
{
    internal class OperacoesList
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                WriteLine($"Indice{i}, valor: {lista[i]}");
            }
        }
    }
}
