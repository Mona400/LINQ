/*
Example 10:

Write a query that returns most frequent character in string. Assume that there is only one such character.
Expected input and output
"panda" → 'a' "n093nfv034nie9"→ 'n'


*/
/* Solution */
    var str = "MonaaaanaaanAaa";
    var mostFrequentCharacter = str.GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault().Key;
    Console.WriteLine(  mostFrequentCharacter);   //a
