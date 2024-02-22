using System;

class aula22
{
	static void Main()
	{
		// Declaração de variáveis para dividendo, divisor, resto e quociente
		int Dividendo, Divisor, rest, quociente;

		// Atribuição de valores para Divid e Divis
		Dividendo = 10;
		Divisor = 5;

		// Chamada do método Dividir, passando Divid e Divis como argumentos, e recebendo o resultado em quociente e rest
		quociente = Dividir(Dividendo, Divisor, out rest);

		// Impressão dos resultados
		Console.WriteLine("Divisor: {0}, Dividendo: {1} é igual ao quociente: {2} e o resto: {3}", Divisor, Dividendo, quociente, rest);
	}

	// Método que realiza a divisão, calcula o quociente e o resto
	static int Dividir(int dividendo, int divisor, out int resto)
	{
		int quociente;

		// Calculando o quociente
		quociente = dividendo / divisor;

		// Calculando o resto e atribuindo ao parâmetro de saída 'resto'
		resto = dividendo % divisor;

		// Retornando o quociente
		return quociente;
	}
}
