namespace ConsoleApp1
{
    public class CountingRhyme
    {
        public int GetLastRemaining(int N, int M)
        {
            if (N <= 0 || M <= 0)
                throw new ArgumentException("N and M must be positive numbers.");

            var currentIndex = 0;
            for (int i = 1; i <= N; i++)
            {
                currentIndex = (currentIndex + M) % i;
            }

            return currentIndex + 1;
        }
    }
}
