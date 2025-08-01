using System; 

class URI {

    static void Main(string[] args) { 

         string line;
        while ((line = Console.ReadLine()) != null)
        {
            int N = int.Parse(line);
            int custoPorDia = int.Parse(Console.ReadLine());
            int[] receitas = new int[N];
            for (int i = 0; i < N; i++)
            {
                receitas[i] = int.Parse(Console.ReadLine());
            }

            int maxLucro = 0;
            for (int i = 0; i < N; i++)
            {
                int soma = 0;
                for (int j = i; j < N; j++)
                {
                    soma += receitas[j];
                    int lucro = soma - (custoPorDia * (j - i + 1));
                    maxLucro = Math.Max(maxLucro, lucro);
                }
            }

            Console.WriteLine(maxLucro);
        }

    }

}