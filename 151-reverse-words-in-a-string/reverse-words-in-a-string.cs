public class Solution {
    public string ReverseWords(string s) {
        if(s==null) return null;
        string[] answer = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(answer);
        return string.Join(" ",answer);
    }
}