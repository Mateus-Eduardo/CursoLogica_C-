// See Array / Vetor Unidimensionais

						//Em programação, um array é uma estrutura de dados
						//que armazena uma coleção de elementos do mesmo tipo,
						//acessíveis por meio de índices ou chaves. Os elementos
						//dentro de um array são armazenados em posições consecutivas
						//de memória e são identificados por índices numéricos.
						//O primeiro elemento geralmente tem o índice 0, o segundo
						//o índice 1 e assim por diante.
						//

// Esta linha inclui o namespace System, que contém classes fundamentais e de base.
using System;

// Esta é a declaração de uma classe chamada "aula15".
class aula15
{
	// Este é o ponto de entrada do programa. O método Main é o ponto de início da execução.
	static void Main()
	{


		int[] n = new int[5]; // Esta linha declara um array de inteiros chamado 'n' com um tamanho de 5.
							  // Utilizando o Array

		int[] numeros = { 1, 2, 3, 4, 5 };
		// Array de inteiros com 5 elementos, inicializado com valores específicos.

		int[] numeros1 = new int[5] { 1, 2, 3, 4, 5 };
		// Array de inteiros com 5 elementos, inicializado com valores específicos

		int[] numeros2; // A array é declarado, mas ainda não foi inicializado.



		string[] veiculos = new string[3];

		// declarando o tipo do array

		// iniciando com o nome da variavel

		// new cria um novo array de strings com um tamanho especificado de 3 elementos.
		// A palavra-chave new é usada para alocar espaço na memória para o array e inicializá-lo
		// com os valores padrão para o tipo (no caso de strings, os valores padrão são null).


		// Estas linhas atribuem valores aos elementos do array 'Veiculos'.

		veiculos[0] = "carro";
		veiculos[1] = "moto";
		veiculos[2] = "aviao";


		// Estas linhas atribuem valores aos elementos do array 'n'.
		n[0] = 11;
		n[1] = 12;
		n[2] = 13;
		n[3] = 14;
		n[4] = 15;

		// Esta linha imprime os valores do primeiro e segundo elementos do array 'n' no console.
		// A string de formato "{0} {1}" especifica onde os valores de n[0] e n[1] serão inseridos.
		Console.WriteLine("{0} {1}", n[0], n[1]);
	}
}
