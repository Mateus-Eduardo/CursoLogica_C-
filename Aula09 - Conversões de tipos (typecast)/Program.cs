// See Conversões de tipos (typecast) 

//As conversões de tipos, também conhecidas como typecasts, são operações que permitem converter 
//um valor de um tipo de dado para outro. Em C#, existem dois tipos principais de conversões: 
//as conversões implícitas e as conversões explícitas.


using System;

class Aula09
{
	static void Main()
	{
		float n = 10.2f;
		int n2 = (int)n; // Usa o typecast para converter o valor de float para int.

		double numero = 10;
		float antena = 1;

		antena = (float)numero;
		// em vez da variavel antena receber 1 ela recebe
		// o valor da variavel numero sendo convertida em float adquirindo o valor 10

		Console.WriteLine(numero);
		Console.WriteLine(antena);

		// + 1 exemplo

		int num1 = 5;
		int num2 = 2;
		// convertendo a variavel antes dela descartar que a variavel 5 e 2 e inteira
		// e apenas dar o resultado = 2, colocamos o typecast na variavel resultado.
		double resultado = (double)num1 / num2;

		Console.WriteLine(resultado);


	}
}

// No trecho abaixo, é explicado o conceito de typecast implícito em C#.
// Um typecast implícito ocorre quando não é necessário um esforço explícito do programador
// para converter um tipo de dado em outro. Isso acontece quando há compatibilidade direta
// entre os tipos envolvidos e não há risco de perda de dados.

// Exemplo específico de typecast implícito:
//-----------int intValue = 42;
//-----------long longValue = intValue;

// Aqui ocorre um typecast implícito de int para long.
// Isso é seguro, pois um long pode armazenar todos os valores possíveis de um int sem perda de dados.

// O typecast implícito é útil em situações em que não há ambiguidade ou risco de perda de dados,
// proporcionando conveniência ao programador sem a necessidade de uma conversão explícita.

//-------------------------------------------------------------------------------------------------------

// No contexto do typecast explícito em C#, é necessário um esforço explícito do programador
// para converter um tipo de dado em outro. Isso se torna necessário quando há risco de perda de dados
// ou quando os tipos envolvidos não são diretamente compatíveis.

// Exemplo específico de typecast explícito:
//-----------double doubleValue = 42.56;
//-----------int intValue = (int)doubleValue;

// Aqui ocorre um typecast explícito de double para int.
// O programador utiliza o operador de typecast explícito (int) para indicar a conversão desejada.

// O typecast explícito é crucial em situações onde a conversão entre tipos não é direta ou quando
// há a possibilidade de perda de dados. O operador (tipo)expressao é usado para realizar essa conversão
// de maneira explícita, permitindo ao programador controlar o comportamento da conversão.
