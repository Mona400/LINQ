/*
Example 2

Write a query that returns words at least 5 characters long and make them uppercase.
Expected input and output
"computer", "usb" → "COMPUTER"

*/

/*Solution*/
 List<string> names = new List<string>() { "mona","abdelmonem","ali","mostafa","abdlahamn"};
            var res = names.Where(x=>x.Length>=5).Select(x =>x.ToUpper());
            foreach (var n in res)
            {
                Console.Write(n+" ");   //ABDELMONEM MOSTAFA ABDLAHAMN
            }
