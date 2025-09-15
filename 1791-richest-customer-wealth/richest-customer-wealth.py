class Solution:
    def maximumWealth(self, nums: List[List[int]]) -> int:
        max1 = 0
        for i in nums:
            final = sum(i)
            if final> max1:
                max1 = final
        return max1
            
            
        