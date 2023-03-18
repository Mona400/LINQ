/*
Example 13:

Write a query that returns dot product of two arrays.
Expected input and output
[1, 2, 3], [4, 5, 6] → 32 [7, -9, 3, -5], [9, 1, 0, -4] → 74


*/

/* Solution */

  List<int> list1 = new List<int>() { 1,2,3};

  List<int> list2 = new List<int>() { 4,5,6};

  var res = list1.Zip(list2,(a,b)=>a*b).Sum();
  Console.WriteLine(  res);
