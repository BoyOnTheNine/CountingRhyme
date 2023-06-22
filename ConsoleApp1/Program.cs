using ConsoleApp1;

public class Program
{
    // count of children
    const int N = 5;

    // length of rhyme
    const int M = 7;


    public static void Main()
    {
        var counting = new CountingRhyme();

        var last = counting.GetLastRemaining(N, M);

        Console.WriteLine(last);
    }
}