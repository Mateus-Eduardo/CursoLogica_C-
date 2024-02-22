// Comentários explicativos para o código que utiliza o comando goto

class Aula14
{
	static void Main()
	{
		// Declaração de variáveis
		int tempo = 0;
		char escolha;

	// mostra o inicio do programa
	inicio:

		Console.Clear();

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

		// Pergunta se o usuário deseja calcular outro transporte
		Console.WriteLine("Calcular outro transporte [s/n]");
		escolha = char.Parse(Console.ReadLine());

		// Se a escolha for 's' ou 'S', volta para o início usando goto
		if (escolha == 's' || escolha == 'S')
		{
			goto inicio;
			// Comando goto
		}
		else
		{
			// Se a escolha for diferente de 's' ou 'S', exibe mensagem e encerra o programa
			Console.Clear();
			Console.WriteLine("Fim do Programa");
		}
	}
}


/*
	 O comando goto é uma instrução de controle de fluxo que existe em muitas linguagens de programação.
	Ele permite que você transfira o controle do programa para uma determinada etiqueta (ou rótulo)
	dentro do código. O uso do goto, no entanto, é geralmente desencorajado e considerado uma prática
	de programação ruim, porque pode tornar o código difícil de entender e dar origem a problemas
	conhecidos como "goto spaghetti" (código inextricável). 
 */