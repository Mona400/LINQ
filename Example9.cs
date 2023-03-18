/*
Example 9:
Given a non-empty string consisting only of special chars (!, @, # etc.), return a number (as a string)
where each digit corresponds to given special char on the keyboard ( 1→ !, 2 → @, 3 → # etc.).
Expected input and output
"())(" → "9009" "*$(#&" → "84937" "!!!!!!!!!!" → "1111111111"


*/
/*Solution*/

 var ch=new char[] { ')', '!', '@', '#', '$', '%', '^', '&', '*', '('};

  var encryptedNumber = "#(@*%)$(&$*#&";

  var decryptedNumber =string.Join("", encryptedNumber.Select(x => Array.IndexOf(ch, x)));

  Console.WriteLine(decryptedNumber); // 3928504974837
