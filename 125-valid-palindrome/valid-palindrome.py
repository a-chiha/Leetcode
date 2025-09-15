class Solution:
    def isPalindrome(self, s: str) -> bool:
        s = ''.join([char for char in s if char.isalnum()]).lower()
        if s == "":
            return True
        if len(s) == 1:
            return True
        n = len(s)
        i = 0
        j = n-1
        while i < n and j > 0:
            if s[i] == s[j]:
                i+=1
                j-=1
            else:
                return False
            if i == j:
                return True
        return True
            
        
        

        
        