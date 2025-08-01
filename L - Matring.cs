using System; 

class URI {

    static void Main(string[] args) { 

string[] s = new string[4];
        for (int i = 0; i < 4; i++)
            s[i] = Console.ReadLine();

        int chain = s[0].Length;
        string[] m = new string[chain];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < chain; j++)
                m[j] += s[i][j];
        }

        long[] vet = new long[chain];
        for (int i = 0; i < chain; i++)
            vet[i] = long.Parse(m[i]);

        for (int i = 1; i < chain - 1; i++)
        {
            char caractere = (char)((vet[0] * vet[i] + vet[chain - 1]) % 257);
            Console.Write(caractere);
        }
        Console.WriteLine();
    }

}