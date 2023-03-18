/*
Example 11:

Given a non-empty list of strings, return a list that contains only unique (non-duplicate) strings.
Expected input and output
["abc", "xyz", "klm", "xyz", "abc", "abc", "rst"] → ["klm", "rst"]

*/

/*Solution*/

 List<string> str = new List<string>() { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" }; 
var res=str.GroupBy(x => x).Where(x=>x.Count()==1);
foreach (var item in res)
{
    Console.Write( $"{item.Key} ");//klm rst
}
