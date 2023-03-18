/*
Example 7:
Given a non-empty list of words, sort it alphabetically and return a word that contains letter 'e'.
Expected input and output
["plane", "ferry", "car", "bike"]→ "plane"

*/

/*Solution*/

  List<string> names = new List<string>() { "plane", "ferry", "car", "bike" };
  var res = names.OrderBy(x => x).LastOrDefault(x => x.EndsWith('e'));

  Console.Write(res + " ");   //plane
