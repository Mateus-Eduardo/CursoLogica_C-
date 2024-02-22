// Aula 03 Operadores e Operações  de Atribuicao


using System;

class Aula03
{
	static void Main()
	{
		// + (adição): Soma dois valores.
		int soma = 5 + 3; // A variável 'soma' conterá 8

		// - (subtração): Subtrai o segundo valor do primeiro.
		int subtracao = 10 - 4; // A variável 'subtracao' conterá 6

		// * (multiplicação): Multiplica dois valores.
		int multiplicacao = 3 * 4; // A variável 'multiplicacao' conterá 12

		// / (divisão): Divide o primeiro valor pelo segundo.
		float divisao = 15.0f / 2; // A variável 'divisao' conterá 7.5

		// % (módulo): Retorna o resto da divisão do primeiro valor pelo segundo.
		int modulo = 17 % 5; // A variável 'modulo' conterá 2 (resto da divisão de 17 por 5)

		// Operadores de Comparação:

		// == (igual a): Verifica se dois valores são iguais.
		bool saoIguais = (7 == 7); // A variável 'saoIguais' conterá true

		// != (diferente de): Verifica se dois valores são diferentes.
		bool saoDiferentes = (10 != 5); // A variável 'saoDiferentes' conterá true

		// < (menor que), > (maior que), <= (menor ou igual a), >= (maior ou igual a): Realizam comparações de magnitude.
		bool menorQue = (8 < 12); // A variável 'menorQue' conterá true

		// Operadores Lógicos:

		// && (E lógico): Retorna verdadeiro se ambas as condições forem verdadeiras.
		bool condicao1 = true;
		bool condicao2 = false;
		bool resultadoLogicoE = (condicao1 && condicao2); // A variável 'resultadoLogicoE' conterá false

		// || (OU lógico): Retorna verdadeiro se pelo menos uma condição for verdadeira.
		bool resultadoLogicoOu = (condicao1 || condicao2); // A variável 'resultadoLogicoOu' conterá true

		// ! (NÃO lógico): Inverte o valor da condição.
		bool inversaoLogica = !condicao1; // A variável 'inversaoLogica' conterá false


		// Operações com Varieveis.

		int valor1 = 30;
		int valor2 = 10;
		int res = (valor1 + valor2) / 2;

		// Incrementando valores a Variavel.

		int Incremento = 10;
		Incremento = Incremento + 1;
		// Forma resumida Incremento += 1;

		// Escrevendo os resultados das Varieaveis.
		Console.WriteLine(soma);
		Console.WriteLine(subtracao);
		Console.WriteLine(multiplicacao);
		Console.WriteLine(divisao);
		Console.WriteLine(modulo);
		Console.WriteLine(saoDiferentes);
		Console.WriteLine(menorQue);
		Console.WriteLine(condicao1);
		Console.WriteLine(condicao2);
		Console.WriteLine(resultadoLogicoE);
		Console.WriteLine(resultadoLogicoOu);
		Console.WriteLine(inversaoLogica);
		Console.WriteLine(res);
		Console.WriteLine(Incremento);



		// outros tipos de exemplos com exercicios verificando
		// se o numero e impar ou par com o mod %



		int num = 12;
		int num2 = 2;

		int div = num % num2;

		if (div == 0)
		{
			Console.WriteLine($"o numero {div} e Par");
		}
		else

		{
			Console.WriteLine($"o numero {div} e impar");
		}

	}
}