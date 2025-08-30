class Solution:
    def canConstruct(self, ransomNote: str, magazine: str) -> bool:
        map1 = {}
        for i in magazine:
            if i not in map1:
                map1[i] = 1
            else:
                map1[i] += 1
        for j in ransomNote:
            if j not in map1 or map1[j] == 0:
                return False
            map1[j] -=1
        return True

        