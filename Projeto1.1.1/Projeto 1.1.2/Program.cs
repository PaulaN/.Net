using System;
using System.IO;
using System.Collections;
using System.Windows;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Projeto_1._1._2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			
			#region Matrizes para usar
			int[] words = { 3, 1, 2, 11, 4,
									 5, 8, 6, 7,9,10};

		    int[] words2 = { 0,0,0,0,0,0,0,0,0,0,0,0};
			#endregion

			#region Ordena a matriz
			//Ordena a matriz
			Array.Sort(words);
			#endregion

            #region Faz uma cópia de uma matriz para outra 
			//Array.ConstrainedCopy(words,0,words2,0,words.Length);
			Array.Copy(words, words2, words.Length);
			#endregion

			#region Exibe toda a matriz 
			Array.ForEach(words, s => Console.WriteLine(s));
			#endregion

			#region Limpa a matriz
			Array.Clear(words2,0,words.Length);
			#endregion

			#region Exibe toda a Matriz 
			Array.ForEach(words,s => Console.WriteLine(s));
			#endregion

			#region Encontra o dado na matriz quando encontra da a posição, quando não, dá um número negativo 
			var teste = Array.BinarySearch(words,13);
			#endregion

			#region Converte Matriz de tipo
			Array.ConvertAll<int, string>(words, Convert.ToString);
			#endregion

			#region Aumenta o tamanho da matriz
			Array.Resize(ref words, 13);
			#endregion

			#region Usando a propriedade somente leitura
			IList<Int32> myList = Array.AsReadOnly(words);
			myList[0] = 5;

			for (int i = 0; i < words.Length; i++)
			{
				Console.WriteLine(myList[i]);
			}
			Console.ReadKey();
			#endregion
		}
	}
}
