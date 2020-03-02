using System;
using System.Collections.Generic;

namespace lists {
  class Program {
    static void Main (string[] args) {

      List<string> planetList = new List<string> () { "Mercury", "Mars" };
      planetList.Add ("Jupiter");
      planetList.Add ("Saturn");

      List<string> newPlanetList = new List<string> () { "Uranus", "Neptune" };

      planetList.AddRange (newPlanetList);

      planetList.Insert (1, "Venus");
      planetList.Insert (2, "Earth");
      planetList.Add ("Pluto");

      List<string> rockyPlanets = new List<string> (planetList.GetRange (0, 3));
      planetList.Remove ("Pluto");

      foreach (string planet in planetList) {
        Console.WriteLine (planet);
      }

      Random random = new Random ();
      List<int> numbers = new List<int> {
        random.Next (6),
        random.Next (6),
        random.Next (6),
        random.Next (6),
        random.Next (6),
        random.Next (6),
      };

      for (int i = 0; i < numbers.Count; i++) {
        // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
        if (i == random.Next (6)) {
          Console.WriteLine ("asdf");
        } else {
          Console.WriteLine ("ffff");
        }
      }

      Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string> ();

      wordsAndDefinitions.Add ("Awesome", "The feeling of students when they are learning C#");
      wordsAndDefinitions.Add ("asdf", "aafffff");
      wordsAndDefinitions.Add ("ffff", "sssss");

      foreach (KeyValuePair<string, string> word in wordsAndDefinitions) {
        Console.WriteLine (word);
      }

      List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>> ();

      Dictionary<string, string> excitedWord = new Dictionary<string, string> ();

      excitedWord.Add ("Word", "Excited");
      excitedWord.Add ("Definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
      excitedWord.Add ("Part of speech", "adjective");
      excitedWord.Add ("example sentence", "I am excited to learn c#");

      dictionaryOfWords.Add (excitedWord);

      Dictionary<string, string> newWord = new Dictionary<string, string> ();

      newWord.Add ("Word", "asdf");
      newWord.Add ("Definition", "asdddd");
      newWord.Add ("Part of Speech", "haffff");
      newWord.Add ("example sentence", "fffff");

      dictionaryOfWords.Add (newWord);

      Dictionary<string, string> newerWord = new Dictionary<string, string> ();

      newerWord.Add ("Word", "afff");
      newerWord.Add ("Definition", "dddd");
      newerWord.Add ("Part of Speech", "affsd");
      newerWord.Add ("example sentence", "sssss");

      dictionaryOfWords.Add (newerWord);

      foreach (Dictionary<string, string> word in dictionaryOfWords) {
        // Iterate the KeyValuePairs of the Dictionary
        foreach (KeyValuePair<string, string> wordData in word) {
          Console.WriteLine ($"{wordData.Key}: {wordData.Value}");
        }
      }

    }
  }
}