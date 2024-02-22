// See Loop FOREACH 
using System;

class Aula20
{
	static void Main()
	{
		// Declaração e inicialização de um array de inteiros com 3 elementos
		int[] num = new int[3] { 11, 22, 33 };

		foreach (int i in num)
		{
			// Imprime o valor do elemento atual no console
			Console.WriteLine(i);
		}
	}
}


/* 
// Este é o exemplo utilizando o loop 'for'
for (int i = 0; i < num.Length; i++)
{
	Console.WriteLine(num[i]);
}
*/

// Assim fica a utilização do loop 'foreach'

// O loop 'foreach' itera automaticamente sobre cada elemento do array
// A variável 'i' assume o valor de cada elemento em cada iteração
