// See IF aninhado 
using System;

class Aula12
{
	static void Main()
	{
		// Declaração de variáveis para armazenar as notas do aluno
		int n1, n2, n3;

		// Solicita ao usuário que digite a primeira nota e lê o valor digitado
		Console.WriteLine("Digite Sua Primeira Nota");
		n1 = int.Parse(Console.ReadLine());

		// Solicita ao usuário que digite a segunda nota e lê o valor digitado
		Console.WriteLine("Digite Sua Segunda Nota");
		n2 = int.Parse(Console.ReadLine());

		// Solicita ao usuário que digite a terceira nota e lê o valor digitado
		Console.WriteLine("Digite Sua Terceira Nota");
		n3 = int.Parse(Console.ReadLine());

		// Calcula a média das notas
		int Nota = (n1 + n2 + n3) / 3;

		// Estrutura condicional para determinar a situação do aluno com base na média
		// TEndo Nosso Ainhamento
		if (Nota >= 90 && Nota <= 100)
		{
			Console.WriteLine("Aprovado Maximo");
		}
		else if (Nota >= 80 && Nota < 90)
		{
			Console.WriteLine("Aprovado com louvor");
		}
		else if (Nota >= 50 && Nota < 80)
		{
			Console.WriteLine("Aprovado");
		}
		else
		{
			Console.WriteLine("Recuperação");
		}

		// Exibe a nota final do aluno
		Console.WriteLine("Sua Nota Final foi: " + Nota);
	}
}
