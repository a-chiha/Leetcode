public class Solution {
    public int MaxVowels(string s, int k) {
        HashSet<char> Vowel = new HashSet<char>{'a','e','i','o','u'};
        int i = 0;
        int numOfVowels=0;
        int maxVowels = 0;
    
        for(int j = 0; j<k;j++){
            if(Vowel.Contains(s[j]))
            numOfVowels++;
        }
    maxVowels = numOfVowels;
    for(i=k; i<s.Length;i++){
        if (Vowel.Contains(s[i])) {
            numOfVowels++;
            }
            if (Vowel.Contains(s[i - k])) {
                numOfVowels--;  
                }
            maxVowels = Math.Max(maxVowels, numOfVowels);
    }

return maxVowels;
    }

}