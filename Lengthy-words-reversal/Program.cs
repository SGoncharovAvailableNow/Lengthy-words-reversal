using Lengthy_words_reversal.Lengthy_words_reversal_class;

internal class Program
{
    private static void Main(string[] args)
    {
        WordsReversalClass.Show(WordsReversalClass.ReversWords("reversed not reversed not reversed"));
        WordsReversalClass.Show(WordsReversalClass.ReversWords("     reve    "));
        WordsReversalClass.Show(WordsReversalClass.ReversWords("     reversed    "));
        WordsReversalClass.Show(WordsReversalClass.ReversWords(null));
        WordsReversalClass.Show(WordsReversalClass.ReversWords("               "));

        Console.ReadKey();
    }
}