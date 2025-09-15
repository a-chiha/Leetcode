class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        map1 = {}
        for i in nums:
            if i not in map1:
                map1[i] = 1
            else:
                map1[i] +=1
        for key,value in map1.items():
            if value > len(nums)//2:
                return key
             
