using System;

class URI
{
    static void Main(string[] args)
    {
        string line;
        int N = 0;

        while ((line = Console.ReadLine()) != null)
        {
            N = int.Parse(line); // Lendo o número de postes
            if (N == 0) break;

            string[] postes = Console.ReadLine().Split(' ');

            int x, p, k, f, r;
            bool b;

            p = k = f = r = 0;
            b = true;

            for (int i = 0; i < N; i++)
            {
                x = int.Parse(postes[i]); // Corrigido índice (postes[i] em vez de postes[i + 1])

                if (x == 1)
                {
                    if (b)
                    {
                        f = k;
                        b = false;
                    }
                    else
                    {
                        r += k / 2;
                    }

                    k = 0;
                }
                else
                {
                    k++;
                }
            }

            r += (k + f) / 2;

            if (b) r += k % 2;

            Console.WriteLine(r);
        }
    }
}