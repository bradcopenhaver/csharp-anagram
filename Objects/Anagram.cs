using System;
using System.Collections.Generic;

namespace Anagram.Objects
{
  public class WordSort
  {
    private string _baseWord;
    private string _testWord;

    private List<string> _anagrams = new List<string>{};
    private List<string> _notAnagrams = new List<string>{};

    public WordSort(string baseword)
    {
      _baseWord = baseword;
    }

    public char[] wordToLetters(string word)
    {
      char[] newCharacterArray = word.ToCharArray();
      Array.Sort(newCharacterArray);
      return newCharacterArray;
    }

    public bool compareArrays()
    {
      char[] bWord = wordToLetters(GetBaseWord());
      char[] tWord = wordToLetters(GetTestWord());
      bool isAnagram = true;

      foreach (char letter in tWord)
      {
        if (Array.IndexOf(bWord, letter) >= 0)
        {
          bWord.SetValue('_', Array.IndexOf(bWord, letter));
        }
        else
        {
          isAnagram = false;
        }
      }
      if (isAnagram)
      {
        _anagrams.Add(GetTestWord());
        return true;
      }
      else
      {
        _notAnagrams.Add(GetTestWord());
        return false;
      }
    }

    public void SetBaseWord(string baseword)
    {
      _baseWord = baseword;
    }
    public string GetBaseWord()
    {
      return _baseWord;
    }
    public void SetTestWord(string testword)
    {
      _testWord = testword;
    }
    public string GetTestWord()
    {
      return _testWord;
    }
    public List<string> GetAnagramList()
    {
      return _anagrams;
    }
    public List<string> GetNotAnagramList()
    {
      return _notAnagrams;
    }
  }
}
