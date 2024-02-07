/* Task:
 * Given a string s, reverse only all the vowels in the string and return it.
 * The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
 */

/* Solution:
 * Creating index and vowel lists, then insert every vowel in reverse order
 */
public class Solution {
    public string ReverseVowels(string s) {
        var vowels = new char[] {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        var index = new List<int>();
        var charArray = s.ToCharArray();;
        var found_vowels = new List<char>();
        for (int i = 0; i < s.Length; i++) {
            if (vowels.Contains(s[i])) {
                index.Add(i);
                found_vowels.Add(s[i]);
            }
        }
        for (int i = 0; i < index.Count; i++) {
            charArray[index[i]] = found_vowels[index.Count - i - 1];
        }
        return new string(charArray); 
    }
}