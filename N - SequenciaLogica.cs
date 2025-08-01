using System; 

class URI {

    static void Main(string[] args) { 

int a = int.Parse(Console.ReadLine());

        for (int b = 1; b <= a; b++)
        {
            int c = b * b;
            int d = b * b * b;
            Console.WriteLine($"{b} {c} {d}");
            
            int e = c + 1;
            int f = d + 1;
            Console.WriteLine($"{b} {e} {f}");
        }

    }

}