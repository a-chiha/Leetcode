public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxLength=0;
        Dictionary<char, int> Freq = new Dictionary<char, int>();
        int i =0;
        for(int j = 0; j<s.Length;j++){
            char letter = s[j];
            if(!Freq.ContainsKey(letter)){
                Freq[letter]=0;
            }
            Freq[letter] +=1;
            int curLength = j-i+1;
            int maxFreq = Freq.Values.Max();
            if(curLength-maxFreq>k){
                Freq[s[i]]--;
                i++;
                curLength = j-i+1;
            }
            
                    maxLength = Math.Max(maxLength,curLength);
        }
return maxLength;
    }
}