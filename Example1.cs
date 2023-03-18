
/*
Example 1:

Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
Expected input and output
[67, 92, 153, 15] → 67, 92

*/

/* Solution*/


 List<int> numbers = new List<int>() { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };
            var res = numbers.Where(x => x > 30).Where(x => x < 100);
            foreach (var x in res)
            {
                Console.Write(x+" ");   //Output: 54 82 95
            }


