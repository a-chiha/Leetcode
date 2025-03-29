public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        int i = 0;
        Dictionary<char, int> seen = new Dictionary<char, int>();
        for(int j=0;j<s.Length;j++){
            char curChar = s[j];
            if(seen.ContainsKey(curChar)){
                i = Math.Max(i,seen[curChar]+1);
            }
            seen[curChar] = j;
            int currentLength = j-i+1;
maxLength = Math.Max(maxLength,currentLength);
        }
        return maxLength;
    }
}