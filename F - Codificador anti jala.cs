using System; 

class URI {

    static void Main(string[] args) { 

  string palavra = Console.ReadLine(); // Lê a palavra a ser codificada
        char[] resultado = new char[palavra.Length];
        int j = 0;

        // Processa as letras nas posições ímpares e pares
        for (int i = 0; i < palavra.Length; i++)
        {
            if (i % 2 == 0)
                resultado[palavra.Length - 1 - j++] = palavra[i]; // Coloca as letras ímpares no final
            else
                resultado[i - j] = palavra[i]; // Coloca as letras pares nas posições correspondentes
        }

        // Exibe a palavra codificada
        Console.WriteLine(new string(resultado));

    }