public class Solution {
    public int HammingDistance(int x, int y) {
        int hammingDistance = 0;
        int xor = x ^ y;
        string bitWiseRep = Convert.ToString(xor, 2);
        foreach (char ch in bitWiseRep)
            if (ch == '1') hammingDistance++;
        return hammingDistance;        
    }
}
