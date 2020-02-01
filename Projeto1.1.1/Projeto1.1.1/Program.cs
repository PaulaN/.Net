using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1._1._1
{
	class Program
	{
		public static void Main(string[] args)
		{
			while (true)
			{
				//Escreve na tela pulando linha
				Console.WriteLine("Escolha no menu a cor da tela que deseja");
				Console.WriteLine("Digite: " + "\n" +
					 "0 -  Black" + "\n" +
					 "1 -  DarkBlue" + "\n" +
					 "2 -  DarkGreen" + "\n" +
					 "3 -  DarkCyan" + "\n" +
					 "4 -  DarkRed" + "\n" +
					 "5 -  DarkMagenta" + "\n" +
					 "6 -  DarkYellow" + "\n" +
					 "7 -  Gray" + "\n" +
					 "8 -  DarkGray" + "\n" +
					 "9 -  Blue" + "\n" +
					 "10 - Green" + "\n" +
					 "11 - Cyan" + "\n" +
					 "12 - Red" + "\n" +
					 "13 - Magenta" + "\n" +
					 "14 - Yellow" + "\n" +
					 "15 - White" + "\n"

					 );
				//Pega a cor digitada
				string numeroDaCor = Console.ReadLine();
				//Seta a cor da fonte no console
				Console.ForegroundColor = ConsoleColor.White;
				
				switch (numeroDaCor)
				{
					case "0":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.Black;
						//Limpa o Console
						Console.Clear();
						break;
					case "1":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.DarkBlue;
						//Limpa o Console
						Console.Clear();
						break;
					case "2":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.DarkGreen;
						//Limpa o Console
						Console.Clear();
						break;
					case "3":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.DarkCyan;
						//Limpa o Console
						Console.Clear();
						break;
					case "4":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.DarkRed;
						//Limpa o Console
						Console.Clear();
						break;
					case "5":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.DarkMagenta;
						//Limpa o Console
						Console.Clear();
						break;
					case "6":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.DarkYellow;
						//Limpa o Console
						Console.Clear();
						break;
					case "7":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.Gray;
						Console.Clear();
						break;
					case "8":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.DarkGray;
						//Limpa o Console
						Console.Clear();
						break;
					case "9":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.Blue;
						//Limpa o Console
						Console.Clear();
						break;
					case "10":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.Green;
						//Limpa o Console
						Console.Clear();
						break;
					case "11":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.Cyan;
						//Limpa o Console
						Console.Clear();
						break;
					case "12":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.Red;
						//Limpa o Console
						Console.Clear();
						break;
					case "13":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.Magenta;
						//Limpa o Console
						Console.Clear();
						break;
					case "14":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.Yellow;
						//Limpa o Console
						Console.Clear();
						break;
					case "15":
						//Seta cor do console
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						//Limpa o Console
						Console.Clear();
						break;
					default:
						Console.WriteLine("Cor não existe");
						Console.Clear();
						break;

				}
				//Escreve no console sem pular linha
				Console.Write("Pressione \"Enter\" para escolher outra cor");
				//Pausa o console até o Enter ser pressionado
				Console.ReadKey();
				
			}
			
			
			




		}
	}
}
