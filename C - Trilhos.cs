using System; 

class URI {

    static void Main(string[] args) { 

         while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0) break;

            string[] inputLines;
            while (true)
            {
                inputLines = Console.ReadLine().Split();
                if (inputLines[0] == "0") break;

                int[] target = Array.ConvertAll(inputLines, int.Parse);
                if (CanReorganize(n, target))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            Console.WriteLine();
        }
    }

    static bool CanReorganize(int n, int[] target)
    {
        int[] stack = new int[n];
        int stackTop = -1;
        int currentTrain = 1;

        foreach (int wagon in target)
        {
            // Add wagons to the stack until we reach the desired wagon
            while (currentTrain <= wagon)
            {
                stack[++stackTop] = currentTrain++;
            }

            // If the desired wagon is on top of the stack, pop it
            if (stackTop >= 0 && stack[stackTop] == wagon)
            {
                stackTop--;
            }
            else
            {
                return false;
            }
        }

        return true;
         

    }

}