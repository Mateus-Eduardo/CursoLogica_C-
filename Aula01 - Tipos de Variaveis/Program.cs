using System;


//class Aula01
//{
//    static void Main()
//     {
// Console.WriteLine("Olá, Mundo!");
//     }
// }

// No contexto de programação em C#, uma variável é um local de armazenamento nomeado que contém um valor.
// Ela serve como um identificador para representar dados armazenados na memória durante a execução de um programa.
// As variáveis têm tipos associados que determinam o tipo de dados que podem armazenar e as operações que podem ser realizadas sobre elas.

// A linguagem C# é fortemente tipada, o que significa que as variáveis devem ser declaradas com um tipo específico antes de serem utilizadas.
// Aqui estão alguns dos tipos de dados mais comuns em C#:

// 1. int: Representa números inteiros, positivos ou negativos, sem parte fracionária.
//    Exemplo:
//    int idade = 25;

// 2. double: Representa números de ponto flutuante de dupla precisão, úteis para valores que podem ter partes fracionárias.
//    Exemplo:
//    double altura = 1.75;

// 3. string: Representa uma sequência de caracteres.
//    Exemplo:
//    string nome = "João";

// 4. bool: Representa um valor booleano, que pode ser verdadeiro (true) ou falso (false).
//    Exemplo:
//    bool estaChovendo = false;

// 5. char: Representa um único caractere Unicode.
//    Exemplo:
//    char letra = 'A';

// 6. DateTime: Representa uma data e hora.
//    Exemplo:
//    DateTime dataAtual = DateTime.Now;

// Estes são apenas alguns exemplos de tipos de dados em C#. É importante escolher o tipo de dados apropriado para garantir
// que a variável possa armazenar os valores necessários de maneira eficiente e sem erros.
// Além disso, as variáveis podem ser modificadas ao longo do tempo, permitindo a manipulação dinâmica de dados durante a execução do programa.

//EXEMPLO


using System;

class Aula01
{
	static void Main()
	{
		// Variáveis declaradas dentro do método Main têm escopo local ao método.

		// Exemplo de variáveis com diferentes tipos de dados:
		int numero = 10;         // Variável do tipo inteiro
		double altura = 1.75;    // Variável do tipo double (número com ponto flutuante)
		string nome = "mateus";  // Variável do tipo string (sequência de caracteres)
		bool tempo = false;      // Variável do tipo booleano
		char letra = 'A';        // Variável do tipo char (caractere Unicode)
		var idade = 14;
		decimal quebrado = 1.0m;
		float quebradn = 2.0f;

		// Conseguimos tambem ver o maximo de valores entre as variaveis

		decimal grandao = decimal.MaxValue;
		decimal pequeno = decimal.MinValue;

		// e isso vale para cada tipo 

		int maximo = int.MaxValue;
		double aaltura = double.MaxValue;



		// Variável do tipo DateTime para armazenar a data e hora atuais.
		DateTime hora = DateTime.Now;

		// Exibindo os valores das variáveis no console.
		Console.WriteLine($"Número: {numero}");
		Console.WriteLine($"Altura: {altura}");
		Console.WriteLine($"Nome: {nome}");
		Console.WriteLine($"Tempo: {tempo}");
		Console.WriteLine($"Letra: {letra}");
		Console.WriteLine($"Hora atual: {hora}");
		Console.WriteLine($"Idade do aluno: {idade}");
		Console.WriteLine($" Decimal com valor maximo :{grandao}");
		Console.WriteLine($" Decimal com valor minimo :{pequeno}");
		Console.WriteLine($" Inteiro com valor maximo :{maximo}"); ;
		Console.WriteLine($"Double com valor maximo {aaltura}");
		Console.WriteLine($" Valor de Decimal{quebradn}");
		Console.WriteLine($" Valor de Flutuante{quebrado}");


		// Aqui termina o escopo do método Main.


	}

	// Variáveis declaradas aqui não são acessíveis dentro do método Main, pois têm escopo local ao método Main.
}
