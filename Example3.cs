/*
Write a query that returns words starting with letter 'a' and ending with letter 'm'.
Expected input and output
"mum", "amsterdam", "bloom" → "amsterdam"

*/

/*Solution*/

List<string> names = new List<string>() { "amonam","abdelmonem","alim","mostafa","abdlahamn","Amamm"};
var res = names.Select(x=>x.ToLower()).Where(x=>x.StartsWith('a')).Where(x=>x.EndsWith('m'));
foreach (var n in res)
{
    Console.Write(n+" ");   //amonam abdelmonem alim amamm
}

