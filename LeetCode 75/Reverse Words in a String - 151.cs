/* Task:
 * Given an input string s, reverse the order of the words.
 * A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.
 * Return a string of the words in reverse order concatenated by a single space.
 * Note that s may contain leading or trailing spaces or multiple spaces between two words. 
 * The returned string should only have a single space separating the words. Do not include any extra spaces.
 */

/* Solution:
 * Skip whitespaces, if character isn't whitespace, set pointer to the end of words
 * As soon, as non whitespace found, insert substring to stringbuilder
 */
public class Solution {
    public string ReverseWords(string s) {
        var pointer = -1;
        StringBuilder sb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] != ' ') {
                if (pointer == -1) {
                    pointer = i;
                }
                if (i == 0) {
                    sb.Append(s.Substring(0, pointer + 1));
                    sb.Append(" ");
                }
            }
            else {
                if (pointer != -1) {
                    sb.Append(s.Substring(i + 1, pointer - i));
                    sb.Append(" ");
                    pointer = -1;
                }
            }
        }
        sb.Length--;
        return sb.ToString();
    }
}