// See Métodos

using System;

class Exemplo
{
	// Método estático sem retorno
	static void MetodoEstatico()
	{
		Console.WriteLine("Método Estático");
	}

	// Método de instância sem retorno
	void MetodoDeInstancia()
	{
		Console.WriteLine("Método de Instância");
	}

	// Método com retorno
	int MetodoComRetorno()
	{
		return 42;
	}

	// Método com parâmetros
	void MetodoComParametros(int a, int b)
	{
		Console.WriteLine($"Soma de {a} e {b} é: {a + b}");
	}

	// Método com modificador 'ref'
	void MetodoRef(ref int x)
	{
		x = x * 2;
	}

	// Método com modificador 'out'
	void MetodoOut(out int y)
	{
		y = 42;
	}

	static void Main()
	{
		// Criando uma instância da classe
		Exemplo obj = new Exemplo();

		// Exemplo de método estático
		MetodoEstatico();

		// Exemplo de método de instância
		obj.MetodoDeInstancia();

		// Exemplo de método com retorno
		int resultado = obj.MetodoComRetorno();
		Console.WriteLine($"Resultado do MétodoComRetorno: {resultado}");

		// Exemplo de método com parâmetros
		obj.MetodoComParametros(10, 20);

		// Exemplo de método com modificador 'ref'
		int a = 10;
		obj.MetodoRef(ref a);
		Console.WriteLine($"Valor alterado por MétodoRef: {a}");

		// Exemplo de método com modificador 'out'
		int b;
		obj.MetodoOut(out b);
		Console.WriteLine($"Valor definido por MétodoOut: {b}");
	}
}

