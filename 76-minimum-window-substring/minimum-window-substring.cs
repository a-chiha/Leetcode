public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int> Freq = new Dictionary<char,int>();
        foreach(char c in t){
            if(!Freq.ContainsKey(c)){
                Freq[c]=0;
            }
            Freq[c]++;
        }    
        int letterToSatisfy = Freq.Count;
        int left = 0;
        int right =int.MaxValue;
        int i = 0;
        for(int j =0; j<s.Length;j++){
         char c = s[j];
         if(Freq.ContainsKey(c)){
            Freq[c]--;
            if (Freq[c] == 0) {
            letterToSatisfy--;
                }
         }   
        while (letterToSatisfy == 0) {
                if (j - i < right - left) {
                    left = i;
                    right = j;
                }
                char leftChar = s[i];
                if (Freq.ContainsKey(leftChar)) {
                    Freq[leftChar]++;
                    if (Freq[leftChar] > 0) {
                        letterToSatisfy++;
                    }
                }
                i++;
            }
        }
 return right == int.MaxValue ? "" : s.Substring(left, right - left + 1);
    }

}