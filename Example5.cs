/*
Example 5:

Write a query that returns list of numbers and their squares only if square is greater than 20
Expected input and output
[7, 2, 30] → 7 - 49, 30 – 900

*/

/*Solution*/

List<int>numbers=new List<int>() { 7, 2, 30 };
var res = numbers.Where(x => x * x > 20);
foreach(int x in res)
{
    Console.Write($"{x} ");  //7 30
}
