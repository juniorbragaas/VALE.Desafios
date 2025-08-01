using System; 

class URI {

    static void Main(string[] args) { 

  // Lendo as listas de amigos
        string[] amigosLuiggy = Console.ReadLine().Split();
        string[] novosAmigos = Console.ReadLine().Split();
        string amigoIndicado = Console.ReadLine();

        // Calculando o tamanho da lista de amigos
        int tamanhoAtual = amigosLuiggy.Length;
        int tamanhoNovos = novosAmigos.Length;

        // Criando um array para a nova lista
        string[] listaFinal = new string[tamanhoAtual + tamanhoNovos];

        if (amigoIndicado != "nao")
        {
            // Encontrar a posição do amigo indicado
            int indice = -1;
            for (int i = 0; i < tamanhoAtual; i++)
            {
                if (amigosLuiggy[i] == amigoIndicado)
                {
                    indice = i;
                    break;
                }
            }

            // Inserir os novos amigos antes do indicado
            for (int i = 0; i < indice; i++)
            {
                listaFinal[i] = amigosLuiggy[i];
            }
            for (int i = 0; i < tamanhoNovos; i++)
            {
                listaFinal[indice + i] = novosAmigos[i];
            }
            for (int i = indice; i < tamanhoAtual; i++)
            {
                listaFinal[tamanhoNovos + i] = amigosLuiggy[i];
            }
        }
        else
        {
            // Inserir os novos amigos no final da lista
            for (int i = 0; i < tamanhoAtual; i++)
            {
                listaFinal[i] = amigosLuiggy[i];
            }
            for (int i = 0; i < tamanhoNovos; i++)
            {
                listaFinal[tamanhoAtual + i] = novosAmigos[i];
            }
        }

        // Exibindo a lista final
        Console.WriteLine(string.Join(" ", listaFinal));
    }

}