// See Operações de Bitwise 

using System;

class Aula07
{
	static void Main()
	{
		// Exemplo de operação AND bitwise
		int numero1 = 10;  // Representação binária: 1010
		int numero2 = 12;  // Representação binária: 1100
		int resultadoAnd = numero1 & numero2;
		Console.WriteLine("AND bitwise: " + resultadoAnd);  // Saída: 8 (representação binária: 1000)

		// Exemplo de operação OR bitwise
		int resultadoOr = numero1 | numero2;
		Console.WriteLine("OR bitwise: " + resultadoOr);    // Saída: 14 (representação binária: 1110)

		// Exemplo de operação XOR bitwise
		int resultadoXor = numero1 ^ numero2;
		Console.WriteLine("XOR bitwise: " + resultadoXor);  // Saída: 6 (representação binária: 0110)

		// Exemplo de operação NOT bitwise
		int numero3 = 10;
		int resultadoNot = ~numero3;
		Console.WriteLine("NOT bitwise: " + resultadoNot);  // Saída: -11 (representação binária: 11110101)

		// Exemplo de shift para a esquerda
		int numero4 = 3;  // Representação binária: 0011
		int resultadoShiftLeft = numero4 << 1;
		Console.WriteLine("Shift para a esquerda: " + resultadoShiftLeft);  // Saída: 6 (representação binária: 0110)

		// Exemplo de shift para a direita
		int numero5 = 12;  // Representação binária: 1100
		int resultadoShiftRight = numero5 >> 1;
		Console.WriteLine("Shift para a direita: " + resultadoShiftRight);  // Saída: 6 (representação binária: 0110)
	}
}



				// Shift para a Esquerda (<<):
				//Desloca os bits para a esquerda, preenchendo os bits
				//vazios à direita com zeros. Isso é equivalente a multiplicar por 2.

				//Shift para a Direita (>>):
				//Desloca os bits para a direita, preenchendo os bits vazios à
				//esquerda com zeros (se for um shift lógico) ou com o bit mais
				//significativo original
				//(se for um shift aritmético). Isso é equivalente a dividir por 2.

