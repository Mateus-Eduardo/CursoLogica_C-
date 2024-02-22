using System;
using System.Runtime.CompilerServices;

// Definição da classe Jogador
class Jogador
{
	// Atributos da classe Jogador
	public int Energia = 100;
	public string nome = "mateus";
	public int idade = 20;

}

// Classe principal Aula24
class Aula24
{
	// Método principal
	static void Main()
	{
		// Criando uma instância da classe Jogador chamada jogador
		Jogador jogador = new Jogador();

		// Criando outra instância da classe Jogador chamada jogador2
		Jogador jogador2 = new Jogador();

		// Exibindo a energia e o nome do jogador
		Console.WriteLine($" Energia do jogador {jogador.Energia}");
		Console.WriteLine($" Nome do jogador {jogador.nome}");

		// Modificando a energia e o nome do jogador2 e exibindo as alterações
		Console.WriteLine($" Energia do jogador 2 {jogador2.Energia = 90}");
		Console.WriteLine($" Nome do jogador 2 {jogador2.nome = "Carlos"}");
	}
}

/*

	 A programação orientada a objetos (OOP) é um paradigma de programação que utiliza conceitos de "objetos",
	os quais são instâncias de classes. Aqui estão alguns conceitos-chave da programação orientada a objetos:

---------------------------------------------------------------------------------------------------
1. **Classes e Objetos:**
   - **Classe:** Uma classe é um modelo ou blueprint para criar objetos.
---------------------------------------------------------------------------------------------------
	Ela define atributos (dados) e métodos (funções) que os objetos podem ter.
	   - **Objeto:** Um objeto é uma instância de uma classe.
	É uma entidade que possui características específicas definidas pela classe.
---------------------------------------------------------------------------------------------------
2. **Encapsulamento:**
   - Encapsulamento é o conceito de agrupar os dados (atributos) 
	e os métodos que operam nesses dados dentro de uma unidade única chamada classe.
   - Fornece controle sobre o acesso aos membros da classe, permitindo ocultar 
	detalhes internos e expor apenas o necessário.
----------------------------------------------------------------------------------------------------
3. **Herança:**
   - A herança permite que uma classe herde características (atributos e métodos) de outra classe.
   - Facilita a reutilização de código e cria uma hierarquia entre as classes.
----------------------------------------------------------------------------------------------------
4. **Polimorfismo:**
   - O polimorfismo permite que objetos de diferentes classes sejam tratados de maneira uniforme.
   - Um objeto pode ser referenciado por meio de uma referência de sua classe base,
	mas pode executar métodos específicos da sua classe real.
-----------------------------------------------------------------------------------------------------
5. **Abstração:**
   - Abstração envolve a simplificação de objetos e operações para modelar 
	o problema do mundo real de forma mais eficaz.
   - Permite concentrar-se apenas nos detalhes relevantes, ignorando aspectos menos importantes.
-----------------------------------------------------------------------------------------------------
	Em resumo, a programação orientada a objetos organiza o código em torno de entidades 
	autônomas chamadas objetos, que são instâncias de classes. Esses objetos têm atributos 
	(dados) e métodos (comportamentos) associados, promovendo a reutilização de código, modularidade
	e uma representação mais próxima do mundo real nos sistemas de software.
-----------------------------------------------------------------------------------------------------
 */

// Fim do curso de Logica de Programacao agora podemos dar entrada a POO - Programacao Orientada Objetos