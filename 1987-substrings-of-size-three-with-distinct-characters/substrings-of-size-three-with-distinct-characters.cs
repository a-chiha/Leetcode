public class Solution {
    public int CountGoodSubstrings(string s) {
         if (s.Length < 3) return 0;
        Dictionary<char,int> seen = new Dictionary<char,int>();
        int i =0;
        int res = 0;
        for(int j = 0; j<s.Length;j++){
             char curChar = s[j];
                if(!seen.ContainsKey(curChar)){
                seen[curChar] = 0;
            }
                seen[curChar]++;

              if (j - i + 1 > 3) {
                seen[s[i]]--;
                if (seen[s[i]] == 0) {
                    seen.Remove(s[i]);
                }
                i++; 
            }
            if (j - i + 1 == 3 && seen.Count == 3) {
                res++;
            }
        }
        return res;
    }
}