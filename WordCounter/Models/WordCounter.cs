using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _word;
    private string _newString;
    public RepeatCounter(string word, string newString)
    {
      _word=word;
      _newString=newString;

    }
    public string GetWord()
    {
      return _word;
    }
    public string GetString()
    {
      return _newString;
    }

  }
}
