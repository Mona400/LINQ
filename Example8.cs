/*
Example 8:

Write a query that shuffles sorted array.
Expected input and output
[1, 2, 3, 4, 5, 6, 7, 8, 9, 10] → [4, 9, 3, 5, 2, 10, 1, 6, 8, 7] [38, 24, 8, 0, -1, -17, -33, -100] → [0, -100, -17, 38, 8, -1, 24, -33,]


*/
/* Solution */

var rnd = new Random();

var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var shuffledArray = array.OrderBy(i => rnd.Next());

foreach (var item in shuffledArray)
{
Console.Write(item + " "); // 4 10 3 6 2 8 1 9 7 5
}
