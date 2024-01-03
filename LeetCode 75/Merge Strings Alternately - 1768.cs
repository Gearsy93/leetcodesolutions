/* Task:
 * You are given two strings word1 and word2.
 * Merge the strings by adding letters in alternating order, starting with word1.
 * If a string is longer than the other, append the additional letters onto the end of the merged string.
 * Return the merged string.
 */

/* Solution:
 * Zipping both strings to get consecutive pairs of characters
 * then adding leftover by slicing longer word (leftover starts index that equals short word length) 
 */
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        return string.Concat(word1.Zip(word2, (letter1, letter2) => $"{letter1}{letter2}")) 
               + ((word1.Length > word2.Length) ? word1 : word2).Substring(Math.Min(word1.Length, word2.Length));
    }
}