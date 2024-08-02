using Lengthy_words_reversal.Lengthy_words_reversal_class;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(WordsReversalClass.ReversWords("     vesr    "));
        Console.WriteLine(WordsReversalClass.ReversWords("     reversed    "));
        Console.WriteLine(WordsReversalClass.ReversWords("               "));
        Console.WriteLine(WordsReversalClass.ReversWords(null));
        Console.WriteLine(WordsReversalClass.ReversWords("reversed not reversed not reversed"));

        Console.ReadKey();
    }
}