using Nancy;
using System;
using System.Collections.Generic;
using Anagram.Objects;

namespace Anagram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post ["/results"] = _ => {
        WordSort newAnagram = new WordSort(Request.Form["base-word"]);
        newAnagram.SetTestWord(Request.Form["test-word1"]);
        newAnagram.compareArrays();
        newAnagram.SetTestWord(Request.Form["test-word2"]);
        newAnagram.compareArrays();
        newAnagram.SetTestWord(Request.Form["test-word3"]);
        newAnagram.compareArrays();
        return View["results.cshtml", newAnagram];
      };
    }
  }
}
