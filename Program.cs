using System;
using static System.Console;
using Arrays.Helper;
using System.Collections.Generic;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //usando list
            OperacoesList opList = new OperacoesList();



            List<string> estados = new List<string>();
            estados.Add("sp");
            estados.Add("mg");
            estados.Add("rs");

            //estados.count (count seleciona o numero de "valores
            WriteLine($"Quantidade elementos lista {estados.Count}");
            //foreach para percorrer todos elementos
            foreach (var item in estados)
            {
                WriteLine(item);
            }
            //list com for
            for (int i = 0; i < estados.Count; i++)
            {
                System.Console.WriteLine($"indice {i}, valor: {estados[i]}");
            }

            //removendo
            opList.ImprimirListaString(estados);
            WriteLine("removendo elemento x");
            estados.Remove("mg");
            opList.ImprimirListaString(estados);

            //OperacoesArray op = new OperacoesArray();
            //int[] array = new int[3] { 3, 2, 1 };
            //int[] arrayCopia = new int[5];
            ////int valorProcurado = 9;

            ////convertendo array para string
            //string[] arrayString = op.ConvertArrayString(array);


            ////Redimensionando array
            //Write($"Capacidade atual array: {array.Length}");
            //op.RedArray(ref array, array.Length * 2);
            //Write($"Capacidade atual array: {array.Length}");

            ////obter indice
            //int indice = op.ObterIndic(array, valorProcurado);

            //if (indice > -1)
            //{
            //    Write("o indice do elemento {0} e: {1}", valorProcurado, indice);
            //}
            //else
            //{
            //    Write("nada");
            //}

            ////encontrar valor
            //int obterValor = op.ObterValor(array, valorProcurado);

            //if (obterValor > 0)
            //{
            //    Write("ok");
            //}
            //else
            //{
            //    Write("nada");
            //}

            ////Maior que todos array            
            //bool tdsMaiorQue = op.TdMaiorQue(array, valorProcurado);
            //if (tdsMaiorQue)
            //{
            //    Write($"Todos são maior que: {valorProcurado}");
            //}
            //else
            //{
            //    WriteLine("nada");
            //}

            ////Procurando Array
            //int valorProcurado = 2;
            //bool exist = op.Exist(array, valorProcurado);

            //if (exist)
            //{
            //    Write($"ok {valorProcurado}");
            //}
            //else
            //{
            //    Write("nada encontrado");
            //}

            ////Array Ordenados
            //Write("array original");
            //op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);


            //Write("array ordenado");
            //op.ImprimirArray(array);

            //Write("array antes copia");
            //op.ImprimirArray(arrayCopia);

            //Write("array pos copia");
            //op.Copiar(ref array, ref arrayCopia);
            //op.ImprimirArray(arrayCopia);

            //int[] arrayInteiros = new int[3];
            //arrayInteiros[0] = 1;
            //arrayInteiros[1] = 2;
            //arrayInteiros[2] = int.Parse("3"); // reconhece apenas numero na string;

            ////matriz "multidimensional";
            //int[,] matriz = new int[4, 2] // 4 linhas e 2 colunas.
            //{
            //    { 0 , 1 },
            //    { 2 , 3 },
            //    { 4 , 5 },
            //    { 6 , 7 }
            //};

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Write(matriz[i, j]);
            //    }
            //}

            ////passando valores matriz
            //matriz[0, 0] = 1;

            ////for
            //Write("Array pelo For");
            //for (int i = 0; i < arrayInteiros.Length; i++)
            //{
            //    Write(arrayInteiros[i]);
            //}

            ////foreach
            //Write("Array pelo ForEach");
            //foreach (int it in arrayInteiros)
            //{
            //    Write(it);
            //}
        }
    }
}
