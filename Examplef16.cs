
/*
Example 16:

Write a query that returns double letters sequence in format: AA AB AC ... ZX ZY ZZ
Expected input and output
(no input) → "AA AB AC ... AZ BA BB ... ZX ZY ZZ"

*/

 var doubleLetters = Enumerable.Range((char)65, 26)
                       .SelectMany(x => Enumerable.Range((char)65, 26).Select(y => (char)x + "" + (char)y));

            foreach (var doubleLetter in doubleLetters)
            {
                Console.Write(doubleLetter + " "); // AA AB AC ... AZ BA BB ... ZX ZY ZZ
            }

