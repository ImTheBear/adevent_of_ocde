using aoc.data_type;

namespace aoc.parser
{
    public class IdParser
    {
        private readonly string _input;
        private IList<IdRange> _idRanges = new List<IdRange>();

        public IdParser(string input_directory)
        {
            _input = input_directory;
        }

        public IList<IdRange> GetInput()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_input))
                {
                    string? line = reader.ReadLine();
                    SplitLineIntoIds(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return _idRanges;
        }

        private void SplitLineIntoIds(string? line)
        {
            if (line == null) return;
            string[] ids = line.Split(',');

            foreach (string id in ids)
            {
                string[] idRange = id.Split('-');
                _idRanges.Add(new IdRange(long.Parse(idRange[0]), long.Parse(idRange[1])));
            }
        }
    }
}
