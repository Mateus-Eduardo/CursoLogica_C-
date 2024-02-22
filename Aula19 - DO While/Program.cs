// See  Loop DO WHILE 

//Exemplo de Sisteminha com Senha 

using System;

class Aula19
{
	static void Main()
	{
		// Definição da senha correta
		string senhaCorreta = "123";

		// Variável para armazenar a senha digitada pelo usuário
		string senhaUsuario;

		// Variável de tentativas de Senha
		int tentativas = 0;

		// Loop do-while para continuar pedindo a senha até que seja digitada corretamente
		do
		{
			// Limpa a tela do console a cada iteração do loop
			Console.Clear();

			// Solicita ao usuário que digite a senha
			Console.WriteLine("Digite a Senha");

			// Lê a senha digitada pelo usuário
			senhaUsuario = Console.ReadLine();

			// Incrementa o número de tentativas
			tentativas++;

			// Se a senha digitada pelo usuário for diferente da senha correta, exibe "Senha Incorreta"
			if (senhaCorreta != senhaUsuario)
			{
				Console.WriteLine("Senha Incorreta. Tente Novamente.");
				Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de limpar a tela
			}

			// Continua o loop enquanto a senha digitada pelo usuário for diferente da senha correta
		} while (senhaCorreta != senhaUsuario);

		// Limpa a tela do console
		Console.Clear();

		Console.WriteLine("Senha Correta. Tentativas: {0}", tentativas);
	}
}

/*
class Aula19
{
    static void Main()
    {
        // Declaração e inicialização de uma variável inteira chamada num com o valor 5.
        int num = 5;

        // Um loop do-while, que garante que o bloco de código dentro das chaves será executado pelo menos uma vez.
        do
        {
            // Imprime a mensagem "Curso Professor Bruno" no console.
            Console.WriteLine("Curso Professor Bruno");

            // A condição do loop: enquanto num for menor que 5, o loop continuará a ser executado.
        } while (num < 5);
    }
}

// simpificando enquanto uma consicao continuar verdadeira o codigo fica se repetindo
	ate ela nao ser e parar
*/
