namespace ConsoleApp1
{
    public class CountingRhyme
    {
        public int GetLastRemaining(int N, int M)
        {
            if (N <= 0 || M <= 0)
                throw new ArgumentException("N and M must be positive numbers.");

            var items = FillIemsList(N).ToList();

            return PerformCountingToLast(M, items);
        }

        private IEnumerable<int> FillIemsList(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                yield return i;
            }
        }

        private int PerformCountingToLast(int M, List<int> items)
        {
            var currentIndex = 0;

            while (items.Count > 1)
            {
                var removeIndex = (currentIndex + M - 1) % items.Count;

                items.RemoveAt(removeIndex);

                currentIndex = removeIndex % items.Count;
            }

            return items.SingleOrDefault();
        }
    }
}
