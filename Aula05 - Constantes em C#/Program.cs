// See Constantes em C#


using System;
using System.Data;
using System.Runtime.CompilerServices;

class Aula05
{
	static void Main()
	{
		const string nome = "Mateus";
		const int numero = 10;



		//Caso queria alterar o valor de uma constante ocorrera um erro 
		// nome = "pedro";


		Console.WriteLine("nome={0}", numero);
	}
}

// TODA CONSTANTE NAO SE ALTERA O VALOR DA VARIAVEL 