using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
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
    //positive test
    [TestMethod]
    public void getTheWordCount_True()
    {
      //Arrange
      string testWord = "eat";
      string testString= "I eat what i eat";
      RepeatCounter newWord = new RepeatCounter(testWord, testString);


      //Act
      string results = newWord.GetWord();
      string result1=newWord.GetString();
      int counter=newWord.CountWord();
      //Assert
      Assert.AreEqual(2, counter);
    }
    // negative test
    [TestMethod]
    public void getTheWordCount_false()
    {
      //Arrange
      string testWord = "eat";
      string testString= "I eat what i eat";
      RepeatCounter newWord = new RepeatCounter(testWord, testString);


      //Act
      string results = newWord.GetWord();
      string result1=newWord.GetString();
      int counter=newWord.CountWord();
      //Assert
      Assert.AreEqual(4, counter);
    }
    [TestMethod]
    public void EnterNumberInsteadWord_false()
    {
      //Arrange
      string testWord = "2";
      string testString= "I eat what i eat in ";
      RepeatCounter newWord = new RepeatCounter(testWord, testString);


      //Act
      string results = newWord.GetWord();
      string result1=newWord.GetString();
      int counter=newWord.CountWord();
      //Assert
      Assert.AreEqual(0, counter);
    }
    [TestMethod]
    public void EmptyStringInsteadWord_true()
    {
      //Arrange
      string testWord = " ";
      string testString= "I eat what i eat in ";
      RepeatCounter newWord = new RepeatCounter(testWord, testString);


      //Act
      string results = newWord.GetWord();
      string result1=newWord.GetString();
      int counter=newWord.CountWord();
      //Assert
      Assert.AreEqual(0, counter);
    }
    // [TestMethod]
    // public void dontCheckNumbers_true()
    // {
    //   //Arrange
    //   string testWord = 1;
    //   string testString= "I eat what 1 i eat in ";
    //   RepeatCounter newWord = new RepeatCounter(testWord, testString);
    //
    //
    //   //Act
    //   string results = newWord.GetWord();
    //   string result1=newWord.GetString();
    //   int counter=newWord.CountWord(results,result1);
    //   //Assert
    //   Assert.AreEqual(0, counter);
    //   //it should h=give an error
    // }
    [TestMethod]
    public void newSetsOfWords_true()
    {
      //Arrange
      string testWord = "Hello";
      string testString= "hello hello hello";
      RepeatCounter newWord = new RepeatCounter(testWord, testString);


      //Act
      string results = newWord.GetWord();
      string result1=newWord.GetString();
      int counter=newWord.CountWord();
      //Assert
      Assert.AreEqual(3, counter);
      //it should h=give an error
    }
    [TestMethod]
    public void ToCheckWordsWithPunctuation_true()
    {
      //Arrange
      string testWord = "Hello";
      string testString= "hello; hello, hello.hello?hello:";
      RepeatCounter newWord = new RepeatCounter(testWord, testString);


      //Act
      string results = newWord.GetWord();
      string result1=newWord.GetString();
      int counter=newWord.CountWord();
      //Assert
      Assert.AreEqual(5, counter);
      //it should h=give an error
    }

  }
}
