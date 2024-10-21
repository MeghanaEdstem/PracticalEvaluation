using System;
using System.Text;

public class TextProcessor
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a paragraph of text:");
        string text = Console.ReadLine();

        int countOfAWords = CountWords(text);
        // int countOfASentence = CountOfASentence(input);
        // int lengthOfAnOutput = input.Length;
        // string longestWord = GetLongestWord(input);
        // string reversedText = ReverseWords(input);

        Console.WriteLine("Number of words:" + countOfAWords);
    //     Console.WriteLine("Number of sentences: " + countOfASentence);
    //     Console.WriteLine("Number of characters: " + lengthOfAnOutput);
    //     Console.WriteLine("Longest word: " + longestWord);
    //     Console.WriteLine("Reversed text: " + reversedText);
    }

    public static int CountWords(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            Console.WriteLine("invalid input");
        } 
        var words = text.Split(' ');
        var totalCharacter = 0;
        var listOfWords = new List<string>();
        foreach(var word in words)
        {
            totalCharacter += word.Count();
            listOfWords.Add(word);
        }
        return ;
    }

    // public static int CountOfASentence(string text)
    // {
    //     if (string.IsNullOrEmpty(text))
    //     {
    //         Console.WriteLine("invalid input");
    //     } 
    //     return ch
    // }

    // public static string GetLongestWord(string text)
    // {
    //     if (string.IsNullOrEmpty(text)) return string.Empty;

    //     string[] words = text.Split(new char[] { ' ', '\t', '\n', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
    //     string longestWord = string.Empty;

    //     foreach (var word in words)
    //     {
    //         if (word.Length > longestWord.Length)
    //         {
    //             longestWord = word;
    //         }
    //     }

    //     return longestWord;
    // }

    // public static string ReverseWords(string text)
    // {
    //     if (string.IsNullOrEmpty(text)) return string.Empty;

    //     StringBuilder reversedText = new StringBuilder();
    //     string[] words = text.Split(' ');

    //     foreach (var word in words)
    //     {
    //         StringBuilder reversedWord = new StringBuilder();
    //         for (int i = word.Length - 1; i >= 0; i--)
    //         {
    //             reversedWord.Append(word[i]);
    //         }
    //         reversedText.Append(reversedWord + " ");
    //     }

    //     return reversedText.ToString().Trim();
    // }
}
