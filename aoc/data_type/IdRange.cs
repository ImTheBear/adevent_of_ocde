namespace aoc.data_type
{
    public class IdRange
    {
        public long Start { get; set; }
        public long End { get; set; }

        public IdRange(long start, long end)
        {
            Start = start;
            End = end;
        }
    }
}
