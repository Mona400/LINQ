/*
Example 12:

Write a query that returns only uppercase words from string.
Expected input and output
"DDD example CQRS Event Sourcing" → DDD, CQRS

*/

/*Solution*/
var str = "HI My this THwww hello HE MONA ma";
var uppercaseOnly = str.Split(' ').Where(x=>string.Equals(x, x.ToUpper()));
foreach (var item in uppercaseOnly)
{
    Console.WriteLine(  item);
}
