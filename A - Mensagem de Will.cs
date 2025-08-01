using System;

class URI
{
    static void Main(string[] args)
    {
        string textoCompleto = "";
        string line;
        int cont = 0;
        string[] alfabeto = new string[10000];
        string[] numero_lampadas_acessas  = new string[10000];
        string[] ordem_lampadas_acessas = new string[10000];
        string[] mensagens;
        int x = -1;

        // Lendo todas as entradas e armazenando em uma string
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            textoCompleto += line + Environment.NewLine;
        }

        // Convertendo para um array de strings
        string[] linhas = textoCompleto.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var item in linhas)
        {
            cont++;
            switch (cont)
            {
               case 1:
                    x++;
                    alfabeto[x] = item;
                    break;
               case 2:
                    numero_lampadas_acessas[x] = item;
                    
                    break;
               case 3:
                    ordem_lampadas_acessas[x] = item;
                    mensagens =  ordem_lampadas_acessas[x].Split(' ');
                    string[] respostas = item.Split(' '); // Corrigido para dividir por um espaço (char)
                    for (int i = 0; i < respostas.Length; i++)
                    {
                        Console.Write((alfabeto[x][(int.Parse(respostas[i])) - 1]).ToString());
                    }
                            Console.WriteLine();
                    cont= 0;
                    break;
            }
        }
        
    }
}