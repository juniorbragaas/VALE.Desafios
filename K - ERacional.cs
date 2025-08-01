using System; 

class URI {

    static void Main(string[] args) { 

 // Lê a entrada e divide em três valores inteiros
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);

        // Se A for 0, a equação deixa de ser do segundo grau
        if (A == 0)
        {
            Console.WriteLine("Y");
            return;
        }

        // Calcula o discriminante (Delta)
        long delta = (long)B * B - 4L * A * C;

        // Verifica se a raiz de Delta é um número inteiro
        long raizDelta = (long)Math.Sqrt(delta);

        if (raizDelta * raizDelta == delta)
        {
            Console.WriteLine("Y"); // Solução racional
        }
        else
        {
            Console.WriteLine("N"); // Solução irracional
        }

    }

}