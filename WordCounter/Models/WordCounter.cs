using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _newString;
    private static List<RepeatCounter> _instances = new List<RepeatCounter> {};
    public RepeatCounter(string word, string newString)
    {
      _word=word;
      _newString=newString;
      _instances.Add(this);

    }
    public string GetWord()
    {
      return _word;
    }
    public string GetString()
    {
      return _newString;
    }
    public static List<RepeatCounter> GetAll()
    {
      return _instances;
    }
    public int CountWord()
    {
      int wordCounter=0;

      if (_word!="")
      {
        string[] stringArray=_newString.Split(' ',',',';','?','.',':');
        for(int i=0; i<stringArray.Length; i++)
        {
          if(_word.ToLower()==stringArray[i])
          {
            wordCounter++;
          }
        }

      }
        return wordCounter;
    }
  }
  // public class Program
  // {
  //   public static void Main()
  //   {
  //     Console.WriteLine("Please enter a word:");
  //     string yourWord = Console.ReadLine();
  //     Console.WriteLine("Enter your string");
  //     string wordString = Console.ReadLine();
  //
  //     RepeatCounter newWord = new RepeatCounter(yourWord, wordString);
  //
  //     Console.WriteLine("RepeatCounter:" + newWord.CountWord());
  //
  //   }
  // }

}
