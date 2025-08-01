using System; 

class URI {

    static void Main(string[] args) { 

      long h, m, s;
        string[] input = Console.ReadLine().Split();
        h = long.Parse(input[0]);
        m = long.Parse(input[1]);
        s = long.Parse(input[2]);

        long n = GCD(GCD(h, m), s);
        Console.WriteLine(n);

        for (long hi = 0; hi < h; hi++)
        {
            if (hi * m % h == 0 && hi * s % h == 0)
            {
                Console.WriteLine($"{hi} {(m * hi) / h} {(s * hi) / h}");
            }
        }

    }
     static long GCD(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

}