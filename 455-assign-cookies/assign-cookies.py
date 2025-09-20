class Solution:
    def findContentChildren(self, g: List[int], s: List[int]) -> int:
        g.sort()
        s.sort()
        if len(s) ==0 or len(g) == 0:
            return 0
        n = len(s)
        j = n-1
        i = len(g)-1
        count = 0
        while i >=0 and j >= 0:
            if s[j] >= g[i]:
                count+=1
                j-=1
            i-=1
        return count

        