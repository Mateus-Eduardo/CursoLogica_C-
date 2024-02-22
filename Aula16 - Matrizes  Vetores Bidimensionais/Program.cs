// See Matrizes / Vetores Bidimensionais

using System;

class Aula16
{
	static void Main()
	{
		// Declaração de uma matriz de inteiros chamada Num com 3 linhas e 5 colunas.
		//[,] se usa para a decaração da Matriz.

		int[,] Num = new int[3, 5];
		int[,] num2 = new int[2, 2] { { 10, 20 }, { 30, 40 } };

		/* 
         
        Inicialização da matriz com valores:
        
        10 20 30 40 50 
        11 21 22 33 44
        31 53 64 65 66

        Lembrando que ao declarar a matriz se declara  numero de Linha depois o Numero de colunas que está;

        */

		// Atribuição de valores à primeira linha da matriz.
		Num[0, 0] = 10; Num[0, 1] = 20; Num[0, 2] = 30; Num[0, 3] = 40; Num[0, 4] = 50;

		// Atribuição de valores à segunda linha da matriz.
		Num[1, 0] = 11; Num[1, 1] = 21; Num[1, 2] = 22; Num[1, 3] = 33; Num[1, 4] = 44;

		// Atribuição de valores à terceira linha da matriz.
		Num[2, 0] = 31; Num[2, 1] = 53; Num[2, 2] = 64; Num[2, 3] = 65; Num[2, 4] = 66;


		Console.WriteLine(Num[1, 2]);
	}
}
