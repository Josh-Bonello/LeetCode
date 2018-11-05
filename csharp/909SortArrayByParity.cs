public class Solution {
    
    public int[] SortArrayByParity(int[] A) {
        var evens = A.Where(a => a % 2 == 0);
        var odds = A.Where(a => a % 2 != 0);
        return evens.Concat(odds).ToArray();
        }
    }
