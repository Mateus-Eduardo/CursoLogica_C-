// See Loop FOR / Estruturas de iteração

using System;

class Aula17
{
	static void Main()
	{


		// Exemplo 1: Contagem decrescente
		for (int i = 5; i >= 1; i--)
		{
			Console.WriteLine(i);
		}
		// Neste exemplo, o loop começa com i igual a 5, decrementa i a cada iteração e imprime o valor de i.


		// Exemplo 2: Incremento diferente
		for (int i = 0; i < 10; i += 2)
		{
			Console.WriteLine(i);
		}
		// Aqui, o loop começa com i igual a 0 e incrementa i em 2 a cada iteração, resultando nos números pares de 0 a 8.



		// Exemplo 3: Utilizando um tipo diferente para a variável de controle
		for (float i = 0.5f; i <= 2.5f; i += 0.5f)
		{
			Console.WriteLine(i);
		}
		// Neste caso, i é uma variável do tipo float, permitindo incrementos de 0.5 até alcançar 2.5.


		// Exemplo 4: Iterar através de uma coleção
		int[] numeros = { 1, 2, 3, 4, 5 };
		foreach (int numero in numeros)
		{
			Console.WriteLine(numero);
		}
		// Utilizando foreach para iterar pelos elementos do array 'numeros' e imprimir cada número.



		// Exemplo 5: Loop infinito com break
		int contador = 0;
		for (; ; )
		{
			Console.WriteLine("Loop infinito!");
			contador++;

			if (contador == 5)
			{
				break; // Saia do loop após 5 iterações
			}
		}

	}
}


/*
            Loop for:
            O loop for é geralmente usado quando você sabe antecipadamente quantas vezes deseja repetir uma ação.

            Sintaxe básica do loop for:

            csharp


            for (inicialização; condição; expressão de iteração)
            {
                // Código a ser repetido
            }



            Inicialização: É onde você inicializa uma variável de controle.
            Condição: É a condição que, enquanto for verdadeira, manterá o loop em execução.
            Expressão de iteração: É onde você atualiza a variável de controle a cada iteração.


*/
