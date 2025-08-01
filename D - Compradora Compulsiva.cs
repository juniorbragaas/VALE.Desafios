using System;

class URI
{
    static void Main(string[] args)
    {
        string textoCompleto = "";
        string line;
        int cont = 0;
        int quantidade_testes = 0;
        int quantidade_comprada = 0;
        int desconto_maximo = 0;

        // Lendo todas as entradas e armazenando em uma string
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            textoCompleto += line + Environment.NewLine;
        }

        // Convertendo para um array de strings corretamente
        string[] linhas = textoCompleto.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        quantidade_testes = int.Parse(linhas[0]);

        for (int i = 0; i < (quantidade_testes * 2); i++)
        {
            cont++;
            if (cont == 1)
            {
                quantidade_comprada = int.Parse(linhas[i + 1]);
            }
            if (cont == 2)
            {
                string valor_cada_item = linhas[i + 1];
                
                // Convertendo para um array de inteiros antes da ordenação
                int[] valores_comprados = Array.ConvertAll(valor_cada_item.Split(' '), int.Parse);
                Array.Sort(valores_comprados);
                Array.Reverse(valores_comprados); // Ordena em ordem decrescente

                for (int k = 0; k < valores_comprados.Length; k++)
                {
                    // A cada 3º item (índices 2, 5, 8, etc.), adiciona ao desconto
                    if ((k + 1) % 3 == 0)
                    {
                        desconto_maximo += valores_comprados[k];
                    }
                }

                cont = 0;
                Console.WriteLine(desconto_maximo);
                desconto_maximo = 0; // Reset para o próximo teste
            }
        }
    }
}