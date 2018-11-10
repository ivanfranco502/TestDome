using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        if (word.Length > 1)
        {
            string wordToEvaluate = word.ToLower();

            int initialValue = 0;
            for (int i = word.Length - 1; i > -1; i--)
            {
                if (wordToEvaluate.Substring(initialValue, 1) != wordToEvaluate.Substring(i, 1))
                    return false;
                initialValue++;
            }

            return true;
        }

        return false;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}
