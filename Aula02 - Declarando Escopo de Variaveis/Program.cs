// See 
//Aula 02 DECARANDO ESCOPOS DE VARIAVEIS



using System;

class Aula02
{
	// Variável global, acessível a todos os métodos dentro da classe.
	static int variavelGlobal = 100;

	static void Main()
	{
		// Variável 'num' é local ao método Main.
		int num = 10;

		// Exibindo o valor da variável 'num' e da variável global 'variavelGlobal'.
		Console.WriteLine($"num: {num}, variavelGlobal: {variavelGlobal}");

		// Chama o método 'teste'.
		teste();
	}

	// Método 'teste'.
	static void teste()
	{
		// Variável 'num2' é local ao método teste.
		int num2 = 20;

		// Exibindo o valor da variável 'num2' e da variável global 'variavelGlobal'.
		Console.WriteLine($"num2: {num2}, variavelGlobal: {variavelGlobal}");
	}
}

/*
---------------------------------------------------------------------------------------------------
 Em C#, os blocos de código são delimitados por chaves {}. 
Variáveis declaradas dentro de um bloco de código são acessíveis apenas 
dentro desse bloco e em blocos internos.

{
    int x = 10; // variável x só é visível dentro deste bloco
    //...
}

---------------------------------------------------------------------------------------------------
Escopo de Funções:

Variáveis declaradas no escopo de uma função são acessíveis apenas dentro dessa função, a menos que declaradas como parâmetros ou tenham escopo mais amplo.
csharp
Copy code
void MinhaFuncao()
{
    int y = 20; // variável y é visível apenas dentro de MinhaFuncao
    //...
}

---------------------------------------------------------------------------------------------------
Escopo de Loops:

O escopo de uma variável declarada dentro de um loop está restrito a esse loop.
csharp
Copy code
for (int i = 0; i < 5; i++)
{
    // variável i só é visível dentro deste loop
    //...
}
---------------------------------------------------------------------------------------------------
Escopo de Condicional:

Variáveis declaradas dentro de uma estrutura condicional (como if ou switch) têm escopo limitado a essa estrutura.
csharp
Copy code
if (condicao)


{
    int z = 30; // variável z só é visível dentro deste bloco condicional
    //...
}

---------------------------------------------------------------------------------------------------
Escopo de Classe:

Membros de classe (variáveis de instância, métodos) têm um escopo mais amplo e são acessíveis em toda a classe.
csharp
Copy code

public class MinhaClasse
{
    int variavelDeClasse = 40; // visível em toda a classe

    void Metodo()
    {
        //...
    }
}

 */