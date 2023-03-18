/*
Example 6:
Write a query that replaces 'ea' substring with astersik (*) in given list of words.
Expected input and output
"learn", "current", "deal" → "l*rn", "current", "d*l"

*/

/* Solution */
  List<string> names = new List<string>() { "learn", "current", "deal" };
  var res = names.Select(x=>x.Contains("ea")?x.Replace("ea","*"):x);
  foreach (var n in res)
  {
      Console.Write(n + " ");   //l*rn current d*l
  }
