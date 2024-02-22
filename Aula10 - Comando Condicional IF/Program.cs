// See Comando condicional IF 

using System;
using System.Net.Http.Headers;

using System;

class Aula10
{
	static void Main()
	{
		// A tradução de 'if' é 'SE', ou seja, se a condição lógica
		// for verdadeira, ele executa o código; se não, ele passa para o próximo.
		// São ultimamente utilizados todos os operadores de expressão lógica.

		// Declaração das variáveis que armazenarão as notas do aluno.
		int n1;
		int n2;
		int n3;

		// Solicita ao usuário que digite a primeira nota.
		Console.WriteLine("Digite sua Primeira nota");
		// Lê a nota inserida pelo usuário a partir do console e converte para um valor inteiro.
		n1 = int.Parse(Console.ReadLine());

		// Solicita ao usuário que digite a segunda nota.
		Console.WriteLine("Digite sua Segunda nota");
		// Lê a segunda nota inserida pelo usuário a partir do console e converte para um valor inteiro.
		n2 = int.Parse(Console.ReadLine());

		// Solicita ao usuário que digite a terceira nota.
		Console.WriteLine("Digite sua Terceira nota");
		// Lê a terceira nota inserida pelo usuário a partir do console e converte para um valor inteiro.
		n3 = int.Parse(Console.ReadLine());

		// Calcula a média das três notas.
		int nota = (n1 + n2 + n3) / 3;


		//-----------------------------------------------------------------------------------------

		// Parte Importante do Codigo o Famoso SI uma condicao for verdadeira faca algo SE nao faca outra coisa

		// Verifica se a média é maior ou igual a 6.
		if (nota >= 6)
		{
			// Se a condição acima for verdadeira, imprime "Aprovado".
			Console.WriteLine("Aprovado");
		}
		else
		{
			// Se a condição acima for falsa, imprime "Reprovado".
			Console.WriteLine("Reprovado");
		}

		// Imprime as notas digitadas pelo usuário.
		Console.WriteLine($"Suas Notas são {n1}, {n2}, {n3}");
		// Imprime a média das notas.
		Console.WriteLine("A Média das Notas é: " + nota);
	}
}
