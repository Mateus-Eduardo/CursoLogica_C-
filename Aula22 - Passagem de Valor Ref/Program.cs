// Passagem por valor e por referência 
using System;
class aula22
{
	static void Main()
	{
		// Declaração e inicialização da variável 'num' com o valor 10
		int valorR = 10;

		// Chamando o método 'Dobrar' e passando a referência da variável 'num'
		Dobrar(ref valorR);

		// Imprimindo o valor atual da variável 'num'
		Console.WriteLine(valorR);
	}

	// Método que recebe um parâmetro por referência e o dobra
	static void Dobrar(ref int valor)
	{
		// Dobrando o valor da variável passada por referência
		valor *= 2;
	}
}

/*
 
 int num = 10;: Aqui, uma variável chamada num é declarada e inicializada com o valor 10.


Dobrar(ref num);: Esta linha chama o método Dobrar e passa a variável num como argumento.
O ref antes de num indica que estamos passando a referência da variável num para o método.


static void Dobrar(ref int valor): Este é o método Dobrar, que recebe um parâmetro valor por referência.
Quando você passa um argumento por referência, você está passando o endereço de memória da variável original,
não apenas o valor. Isso significa que qualquer alteração feita dentro deste método afetará diretamente a 
variável original fora do método.


valor *= 2;: Dentro do método Dobrar, o valor da variável é dobrado (multiplicado por 2).


Console.WriteLine(num);: Após chamar o método Dobrar, a linha imprime o valor atual da variável num.
Como num foi passado por referência, a alteração feita dentro do método Dobrar afeta diretamente o
valor de num fora do método. Portanto, o valor impresso será 20 (10 * 2).


Em resumo, a passagem por referência permite que você altere diretamente 
o valor da variável original passada como argumento para o método, enquanto
a passagem por valor cria uma cópia da variável, e qualquer alteração dentro 
do método não afeta a variável original fora dele. O uso de ref indica 
que você está passando uma referência em C#.

*/