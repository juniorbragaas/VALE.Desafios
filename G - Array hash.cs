using System; 

class URI {

    static void Main(string[] args) { 

    int n = int.Parse(Console.ReadLine()); // Número de casos de teste

        for (int i = 0; i < n; i++)
        {
            int l = int.Parse(Console.ReadLine()); // Número de linhas para o caso de teste
            int hashValue = 0;

            for (int j = 0; j < l; j++)
            {
                string input = Console.ReadLine();
                for (int k = 0; k < input.Length; k++)
                {
                    // Cálculo do valor do caractere
                    int charValue = (input[k] - 'A') + j + k;
                    hashValue += charValue;
                }
            }

            // Exibe o valor do hash
            Console.WriteLine(hashValue);
        }

    }
}