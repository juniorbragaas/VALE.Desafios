using System; 

class URI {

    static void Main(string[] args) { 

 while (true)
        {
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int r = int.Parse(inputs[2]);
            int c = int.Parse(inputs[3]);

            if (n == 0 && m == 0 && r == 0 && c == 0) break;

            char[,] grid = new char[n, m];
            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    grid[i, j] = row[j];
                }
            }

            int operations = 0;
            for (int i = 0; i <= n - r; i++)
            {
                for (int j = 0; j <= m - c; j++)
                {
                    if (grid[i, j] == '1') // Se o pixel é preto, inverte a região
                    {
                        for (int x = i; x < i + r; x++)
                        {
                            for (int y = j; y < j + c; y++)
                            {
                                grid[x, y] = grid[x, y] == '1' ? '0' : '1'; // Inverte o pixel
                            }
                        }
                        operations++;
                    }
                }
            }

            bool possible = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i, j] == '1') // Se algum pixel ainda for preto, impossível
                    {
                        possible = false;
                        break;
                    }
                }
                if (!possible) break;
            }

            Console.WriteLine(possible ? operations.ToString() : "-1");
        }

    }

}