class Solution:
    def summaryRanges(self, nums: List[int]) -> List[str]:
        if not nums:
            return []
        ans = []
        j = 0
        for i in range(1,len(nums)):
            if nums[i] != nums[i-1]+1:  
                if nums[j] == nums[i-1]:
                    ans.append(str(nums[j]))
                else:
                    ans.append(str(nums[j]) + "->" + str(nums[i-1]))
                j = i 

        if nums[j] == nums[-1]:
            ans.append(str(nums[j]))
        else:
            ans.append(str(nums[j]) + "->" + str(nums[-1]))
        
        return ans
        