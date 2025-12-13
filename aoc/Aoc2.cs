using aoc.data_type;
using aoc.parser;

namespace aoc
{
    public class Aoc2
    {
        private long invalidIdSum = 0;
        public void Run()
        {
            IdParser parser = new IdParser("../input/aoc2.txt");
            IList<IdRange> idRanges = parser.GetInput();

            foreach (IdRange idRange in idRanges)
            {
                CheckForInvalidIds(idRange);
            }

            Console.WriteLine($"Sum of invalid ids: {invalidIdSum}");
        }

        private void CheckForInvalidIds(IdRange idRange)
        {
            for (long i = idRange.Start; i <= idRange.End; i++)
            {
                if (CheckIfIdIsPattern(i))
                {
                    invalidIdSum += i;
                }
            }
        }

        private bool CheckIfIdIsPattern(long id)
        {
            string idString = id.ToString();
            int middle = idString.Length / 2;

            string pattern = idString.Substring(0, middle);
            string pattern2 = idString.Substring(middle);

            return pattern == pattern2;
        }
    }
}
