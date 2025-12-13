namespace aoc.parser
{
    public class SafeCombiParser
    {
        private readonly string _input;
        private IList<int> safeCombi;

        public SafeCombiParser(string input_directory)
        {
            _input = input_directory;
            safeCombi = new List<int>();
        }

        public IList<int> GetInput()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_input))
                {
                    while (reader.Peek() >= 0)
                    {
                        string? line = reader.ReadLine();
                        if (line == null) return safeCombi;
                        AddCombi(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return safeCombi;
        }

        private void AddCombi(string readLine)
        {
            if (readLine[0] == 'R')
            {
                safeCombi.Add(int.Parse(readLine.Substring(1)));
            }
            else
            {
                safeCombi.Add(-int.Parse(readLine.Substring(1)));
            }
        }
    }
}
