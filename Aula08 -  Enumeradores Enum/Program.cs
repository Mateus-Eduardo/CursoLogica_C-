// See Enumeradores (enum) 
// (enum) em C#

//para representar os dias da semana. O código define um enumerador chamado DiasSemanas
//com os dias da semana como valores possíveis.



using System;

class Aula8
{
	// Definindo um enumerador chamado DiasSemanas
	enum DiasSemanas { dom, seg, ter, qua, qui, sex, sab };

	static void Main()
	{
		// Inicializando uma variável do tipo DiasSemanas com o valor correspondente ao índice 3 (quarta-feira)

		DiasSemanas ds = (DiasSemanas)3; // usando o cast para converter de string para int indicando o indice

		// Imprimindo o valor da variável
		Console.WriteLine(ds);  // Saída: dom
	}
}

