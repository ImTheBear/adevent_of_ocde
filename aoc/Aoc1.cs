using aoc.safe;
using aoc.parser;

namespace aoc
{
    public class Aoc1
    {
        private string directory;

        public Aoc1(string input_directory)
        {
            directory = input_directory;
        }

        public void Run()
        {
            SafeCombiParser parser = new SafeCombiParser(directory);
            IList<int> safeCombi = parser.GetInput();

            Safe safe = new();
            int landedOnZero = 0;

            foreach (int i in safeCombi)
            {
                safe.Move(i);

                if (safe.CurrentValue == 0)
                {
                    landedOnZero++;
                }
            }
            Console.WriteLine($"Went over zero {safe.WentOverZero} times");
            Console.WriteLine($"Landed on zero {landedOnZero} times");

        }
    }
}
