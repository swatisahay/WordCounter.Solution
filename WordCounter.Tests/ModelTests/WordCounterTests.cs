using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    // public void Dispose()
    //  {
    //    RepeatCounter.ClearAll;
    //  }
    [TestMethod]
    public void getWordReturnWord_True()
    {
      //Arrange
      string testWord = "eat";
      string testString= "my name is swati";
      RepeatCounter newWord = new RepeatCounter(testWord, testString);


      //Act
      string results = newWord.GetWord();
      string result1=newWord.GetString();

      //Assert
      Assert.AreEqual(testWord, results);
      Assert.AreEqual(testString, result1);

    }
  }
}
