// See SWITCH case 



using System;

class Aula13
{
	static void Main()
	{
		// Declaração de variáveis
		int tempo = 0;
		char escolha;

		// Mensagens para o usuário
		Console.WriteLine("Viagem de Igaraçu a Barra Bonita ");
		Console.WriteLine("ESCOLHA O TRANSPORTE [a] avião [c] carro [o] Onibus");

		// Leitura da escolha do usuário
		escolha = char.Parse(Console.ReadLine());

		// Switch para calcular o tempo de viagem com base na escolha do usuário
		switch (escolha)
		{
			case 'a':
			case 'A':
				tempo = 50;
				break;
			case 'c':
			case 'C':
				tempo = 480;
				break;
			case 'o':
			case 'O':
				tempo = 680;
				break;
			default:
				// Caso a escolha não seja válida, tempo é definido como -1
				tempo = -1;
				break;
		}

		// Verificação do tempo e exibição de mensagens correspondentes
		if (tempo < 0)
		{
			Console.WriteLine("Transporte indefinido");
		}
		else
		{
			Console.WriteLine("O tempo é: {0} minutos", tempo);
		}
	}
}
