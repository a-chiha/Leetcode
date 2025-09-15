class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        map1 = {}
        for i in nums:
            if i not in map1:
                map1[i] = 1
            else:
                map1[i] +=1
        for key,value in map1.items():
            if value > 1:
                return True
        return False
        




