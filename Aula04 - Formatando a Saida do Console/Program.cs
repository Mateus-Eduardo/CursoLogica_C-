// Formatando a Saida do Console 
using System;
using System.ComponentModel;
using System.Globalization;

// Comandos como
// Console.Writeline();
// Console.Write(); Diferenca ele nao quebra linha no final
// Concatenacao

class Aula04
{
	static void Main()
	{
		int n1, n2, n3;

		n1 = 10;
		n2 = 20;
		n3 = 30;
		//Usando String Interpolation sem Impressão Direta:
		//A interpolação de string, indicada pelo cifrão e chaves (${}),
		//permite que você insira expressões dentro de uma string. Neste exemplo
		//as variáveis n1, n2 e n3 são incorporadas diretamente na string, tornando
		//o código mais limpo e fácil de ler.

		//Exemplo: de concatenacao que mais usam.
		Console.WriteLine($" mateus tem  {n1} anos, {n2} dias, e {n3} horas de aprendizado");

		//Concatenação de Strings:
		//Neste caso, os marcadores de posição {0}, {1}, e {2}
		//são substituídos pelos valores de n1, n2, e n3, respectivamente.
		//Isso é uma técnica útil quando você precisa de uma formatação
		//mais complexa ou quando deseja reutilizar a mesma string de
		//formatação com diferentes valores.

		Console.WriteLine("---------------------");
		//Exemplo:
		Console.WriteLine("n1={0}, n2={1}, n3={2}", n1, n2, n3);



		Console.WriteLine("---------------------");
		//Concatenação com o Método Concat
		//O método Concat pode ser utilizado para concatenar várias strings em uma única string.


		//Exemplo:
		Console.WriteLine(string.Concat("n1=", n1, ", n2=", n2, ", n3=", n3));

		// Outros Exemplos de Saida

		char genero = 'M';
		double salario = 10.32651;


		Console.WriteLine("com quebra de linha");

		Console.WriteLine("---------------------");
		Console.Write("sem quebra de linha");
		Console.WriteLine("--------------------");
		Console.WriteLine("---------------------");

		// Exemplo usando o (+ e a variavel ) 
		Console.WriteLine("Genero" + genero);
		Console.WriteLine("---------------------");
		// Exempo controlando o numero de casas decimais a ver / no caso2 casas depois da virgula
		Console.WriteLine(salario.ToString("F2"));
		Console.WriteLine(salario.ToString("F4"));



		Console.WriteLine("---------------------");
		// Exemplo formatando com o cuture info que em vez da virgula me tras o ponto final separando 
		Console.WriteLine(salario.ToString("f2", CultureInfo.InvariantCulture));
	}
}