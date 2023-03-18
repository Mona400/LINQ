/*
Example 4:

Write a query that returns top 5 numbers from the list of integers in descending order.
Expected input and output
[78, -9, 0, 23, 54, 21, 7, 86] → 86 78 54 23 21

*/

/*Solution*/

List<int>numbers=new List<int>() { 78, -9, 0, 23, 54, 21, 7, 86 };
var res=numbers.OrderByDescending(x=>x).Take(5).ToList();
foreach(int x in res)
{
    Console.Write($"{x} ");  //86 78 54 23 21 
}
