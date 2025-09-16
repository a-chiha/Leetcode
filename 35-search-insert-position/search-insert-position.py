class Solution:
    def searchInsert(self, nums: List[int], target: int) -> int:
        result = 0
        for x in nums:
            if x == target:
                return result
            if x > target:
                return result  
            result+=1
        return result