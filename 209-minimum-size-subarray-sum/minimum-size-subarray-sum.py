class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        minLen= float("inf")
        curLen = 0
        cur = 0
        i = 0
        j = 0
        while i < len(nums) and j < len(nums):
            cur += nums[j]
            j+=1
            while cur >= target:
                curLen = j-i
                minLen = min(minLen,curLen)
                cur -= nums[i]
                i+=1
        return 0 if minLen == float('inf') else minLen        