class Solution:
    def maximumWealth(self, nums: List[List[int]]) -> int:
        final = 0
        for i in nums:
            if final < sum(i):
                final = sum(i)
        return final
            
            
        