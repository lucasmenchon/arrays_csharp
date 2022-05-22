using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arrays.Helper
{

    public class OperacoesArray
    {

        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

        }

        public void ImprimirArray(int[] array)
        {
            // Write(array[i]);

            var linha = string.Join(", ", array);
            WriteLine(" " + linha);
        }

        //array metodo sort.
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        //copia array
        public void Copiar(ref int[] array, ref int[] arrayDest)
        {
            Array.Copy(array, arrayDest, array.Length);
        }

    }
}
