using System;
using static System.Console;
using Arrays.Helper;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OperacoesArray op = new OperacoesArray();
            int[] array = new int[3] { 9, 1, 2 };
            int[] arrayCopia = new int[5];

            Write("array original");
            op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);


            Write("array ordenado");
            op.ImprimirArray(array);

            Write("array antes copia");
            op.ImprimirArray(arrayCopia);

            Write("array pos copia");
            op.Copiar(ref array, ref arrayCopia);
            op.ImprimirArray(arrayCopia);
            
            /*int[] arrayInteiros = new int[3];
            arrayInteiros[0] = 1;
            arrayInteiros[1] = 2;
            arrayInteiros[2] = int.Parse("3"); // reconhece apenas numero na string;

            //matriz "multidimensional";
            int[,] matriz = new int[4, 2] // 4 linhas e 2 colunas.
            {
                { 0 , 1 },
                { 2 , 3 },
                { 4 , 5 },
                { 6 , 7 }
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Write(matriz[i, j]);
                }
            }

            //passando valores matriz
            matriz[0, 0] = 1;

            //for
            Write("Array pelo For");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Write(arrayInteiros[i]);
            }

            //foreach
            Write("Array pelo ForEach");
            foreach (int it in arrayInteiros)
            {
                Write(it);
            }*/
        }
    }
}
