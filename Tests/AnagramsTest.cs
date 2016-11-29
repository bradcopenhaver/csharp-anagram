using Xunit;
using System.Collections.Generic;
using System;
using Anagram.Objects;

namespace Anagram
{
  public class WordSortTest
  {
    [Fact]
    public void wordToLetters_wordToLetters_true()
    {
      //Arrange
      char[] expectedResult = {'a', 't'};
      WordSort newAnagram = new WordSort("at");
      //Act
      char[] result = newAnagram.wordToLetters("at");
      //Assert
      Assert.Equal(result, expectedResult);
    }
    [Fact]
    public void wordToLetters_sortLettersAlphabetical_true()
    {
      //Arrange
      char[] expectedResult = {'a', 'c', 't'};
      WordSort newAnagram = new WordSort("cat");
      //Act
      char[] result = newAnagram.wordToLetters("cat");
      //Assert
      Assert.Equal(result, expectedResult);
    }
    [Fact]
    public void wordToLetters_compareArrays_true()
    {
      //Arrange
      WordSort newAnagram = new WordSort("cat");
      newAnagram.SetTestWord("act");
      //Act
      bool result = newAnagram.compareArrays();
      //Assert
      Assert.Equal(true, result);
    }
  }
}
