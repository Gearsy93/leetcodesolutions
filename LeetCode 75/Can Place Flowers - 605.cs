/* Task:
 * You have a long flowerbed in which some of the plots are planted, and some are not.
 * However, flowers cannot be planted in adjacent plots.
 * Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty,
 * and an integer n, return true if n new flowers can be planted in the flowerbed without violating
 * the no-adjacent-flowers rule and false otherwise.
 */

/* Solution:
 * To find number of plantabled flowerbed, for each empty flowerbed streak find its max count of plantable plants:
 * (emptyStreak % 2 == 0) ? (emptyStreak - 1) / 2 : emptyStreak / 2;
 */
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        var plantable = 0;
        var emptyStreak = 0;
        for (int i = 0; i < flowerbed.Length; i++) {
            if (flowerbed[i] == 0) {
                emptyStreak++;
            }
            else {
                plantable += (emptyStreak % 2 == 0) ? (emptyStreak - 1) / 2 : emptyStreak / 2;
                emptyStreak = 0;
            }
        }
        return plantable >= n;
        
    }
}