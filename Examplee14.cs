
/*
Example 14:

Write a query that returns letters and their frequencies in the string.
Expected input and output
"gamma" → "Letter g occurs 1 time(s), Letter a occurs 2 time(s), Letter m occurs 2 time(s)"

*/

/*Solution*/
var str = "MonaMMOOAAAAAAA";
var res = str.ToLower().GroupBy(x => x);
foreach (var item in res)
{
    Console.WriteLine($"{item.Key}  {item.Count()}");
}

/*Output
m  3
o  3
n  1
a  8
*/
