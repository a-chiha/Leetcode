public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> Freq = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (!Freq.ContainsKey(s[i])) {
                Freq[s[i]]=0;
            } 
                Freq[s[i]] ++;
            }
            int letter = Freq.Count();


        for (int i = 0; i < t.Length; i++) {
            if (!Freq.ContainsKey(t[i])) {
                return false;
            }
            Freq[t[i]]--;
                if (Freq[t[i]] < 0) { 
                    return false;
                }
             if(Freq[t[i]]==0){
                letter-- ;
            }
            }
              return letter == 0;
}
      
    }

