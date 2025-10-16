class Solution:
    def findPeakElement(self, nums: List[int]) -> int:
        if len(nums) == 1:
            return 0
        for i in range(1,len(nums)):
            if i == len(nums)-1 and nums[i-1]<nums[i]:
                return i
            if nums[i-1] < nums[i] > nums[i+1]:
                return i
        return 0

        