public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> Freq = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (Freq.ContainsKey(s[i])) {
                Freq[s[i]]++;
            } else {
                Freq[s[i]] = 1;
            }
        }


        for (int i = 0; i < t.Length; i++) {
            if (Freq.ContainsKey(t[i])) {
                Freq[t[i]]--;

                if (Freq[t[i]] == 0) { 
                    Freq.Remove(t[i]);
                }
            } else {
                return false; 
            }
        }

        return Freq.Count == 0;
    }
}
