/*
DESCRIPTION:

Write a function that will check if two given characters are the same case.

If either of the characters is not a letter, return -1
If both characters are the same case, return 1
If both characters are letters, but not the same case, return 0
Examples

'a' and 'g' returns 1
'A' and 'C' returns 1
'b' and 'G' returns 0
'B' and 'g' returns 0
'0' and '?' returns -1
*/


using System;

public class Kata {
    public static int SameCase(char a, char b) {
    if (Char.IsLetter(a) && Char.IsLetter(b))
        {
        if ((Char.IsUpper(a) && Char.IsUpper(b)) || (Char.IsLower(a) && Char.IsLower(b)))
            {
                return 1;
            }
        return 0;
        }
        return -1;
    }
}