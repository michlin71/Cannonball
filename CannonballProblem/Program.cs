using System;

namespace CannonballProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The final solution is: " + GetCannonballSolution());
        }

        static int GetCannonballSolution(int maxIteration = 2000)
        {
            // skipping the trivial iteration 1.
            var iteration = 2;
            var sum = 1;
            double sqrt = 0;

            while (iteration <= maxIteration)
            {
                sum += (int) Math.Pow(iteration, 2);
                sqrt = Math.Sqrt(sum);

                Console.WriteLine($"Iteration: {iteration}, Sum = {sum}, Square Root = {sqrt}");
                if (sqrt % 1 == 0)
                    return iteration;
                iteration++;
            }

            return -1;
        }
    }
}
