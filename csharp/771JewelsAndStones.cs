public class Solution {
    public int NumJewelsInStones(string J, string S) {
        //Setup the groups that are jewels
        char[] jewels = J.ToCharArray();
        //put stones into their groups
        
        //Count the groups
        char[] stones = S.ToCharArray();
        Console.WriteLine(stones);
        int myJewels = 0;
        foreach (char stone in stones){
            foreach(char jewel in jewels){
                if(stone == jewel){
                    myJewels += 1;
                }
            }
        }
        //Return integer result
        return myJewels;
    }
}
