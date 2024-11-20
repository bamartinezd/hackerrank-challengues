/*
Create a function that takes two strings and returns either true or false depending on whether they're perfect anagrams or not.

An anagram is a word or phrase formed by rearranging the letters of a different word or phrase.
A perfect anagram uses all the letters, no more, no less.
Examples



Notes

    Should be case insensitive.
    The strings can be of different length.
    Take into account best practices, validations, error handling and performance.

*/

using System.Linq;

public class Program{

    public static void Main (string [] args){
        
        var result = IsAnagram("William Shakespeare", "I am a weakish speller");//true
        
        // IsAnagram("A gentleman", "elegant man");//true
        // IsAnagram("apple", "peal");//false
        // IsAnagram("Nope", "Note");//false
        
        Console.WriteLine(result);
    }

    public static bool IsAnagram(string firstText, string secondText){
        var wordArray = firstText.Split();

        foreach (var letter in wordArray)
        {
            int countOfLetters = wordArray.Select(x => x.Equals(letter)).Count();
            Console.WriteLine(countOfLetters);    
        }
        

        return true;
    }
}