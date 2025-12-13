namespace aoc.safe
{
    public class Safe
    {
        public int CurrentValue { get; set; }
        public int WentOverZero { get; set; }

        public Safe()
        {
            CurrentValue = 50;
            WentOverZero = 0;
        }

        public void Move(int direction)
        {
            if (direction > 0)
            {
                MoveRight(direction);
            }
            else
            {
                MoveLeft(-direction);
            }
        }

        private void MoveRight(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (CurrentValue == 99)
                {
                    CurrentValue = 0;
                }
                else
                {
                    CurrentValue++;
                }

                if (CurrentValue == 0)
                {
                    WentOverZero++;
                }
            }
        }

        private void MoveLeft(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (CurrentValue == 0)
                {
                    CurrentValue = 99;
                }
                else
                {
                    CurrentValue--;
                }

                if (CurrentValue == 0)
                {
                    WentOverZero++;
                }
            }
        }
    }
}
