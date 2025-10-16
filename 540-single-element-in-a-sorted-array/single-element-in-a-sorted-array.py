class Solution:
    def singleNonDuplicate(self, nums: List[int]) -> int:
        map1 = {}
        for i in nums:
            if i not in map1:
                map1[i] = 1
            else:
                map1[i] +=1
        for k,v in map1.items():
            if v == 1:
                return k
        
        
            
        