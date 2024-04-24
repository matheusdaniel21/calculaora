/*
 * Created by SharpDevelop.
 * User: Joel
 * Date: 20/04/2024
 * Time: 23:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace calculadora
{
	class Program
	{
		public static void Main(string[] args)
		{
			float n1; float n2; string operacao; 
			float soma; float subtracao; float divisao; float mutiplicacao;
			
			Console.WriteLine(" --------------- CALCULADORA -----------------");
			Console.WriteLine();
			Console.WriteLine("Digite dois números e selecione a operação que deseja realizar");
			Console.WriteLine();
			
			try
			{
				
			Console.Write("Digite o primeiro número: ");
			n1 = float.Parse(Console.ReadLine());
			
			Console.Write("Digite o segundo número: ");
			n2 = float.Parse(Console.ReadLine());
			
			Console.WriteLine();
			
			Console.Write("Digite a operação que deseja realizar: +, -, *, /: ");
			operacao = Console.ReadLine();
			
				if (operacao == "+"){
					Console.WriteLine();
					soma = n1 + n2;
					Console.WriteLine("O resultado de " + n1 + " + " + n2 + " é igual a => " + soma);
				}
				
				else if(operacao == "-"){
					Console.WriteLine();
					subtracao = n1 - n2;
					Console.WriteLine("O resultado de " + n1 + " - " + n2 + " é igual a => " + subtracao);
				}
				
				else if(operacao == "*"){
					Console.WriteLine();
					mutiplicacao = n1 * n2;
					Console.WriteLine("O resultado de " + n1 + " * " + n2 + " é igual a => " + mutiplicacao);
				}
				
				else if(operacao == "/"){
					Console.WriteLine();
					divisao = n1 / n2;
					Console.WriteLine("O resultado de " + n1 + " / " + n2 + " é igual a => " + divisao);
				}
				
			}
			
			catch(System.Exception)
			{	
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Tipo de dado não suportado. Programa ENCERRADO! ");
				
			}
			
			Console.ReadKey(true);
		}
	}
}