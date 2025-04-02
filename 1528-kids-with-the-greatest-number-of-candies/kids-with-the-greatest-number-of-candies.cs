public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int maximum = candies.Max();
        List<bool> result = new List<bool>();
        foreach(int i in candies){
         result.Add(i+extraCandies>=maximum);
        }
        return result;
    }
}