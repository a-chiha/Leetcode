class Solution:
    def nextGreaterElement(self, nums1: List[int], nums2: List[int]) -> List[int]:
        j = 0
        ans = [] 
        for i in nums1:
            idx = nums2.index(i)
            for j in range(idx+1,len(nums2)):
                if nums2[j] > i:
                    ans.append(nums2[j])
                    break
            else:
                ans.append(-1)
                    
        return ans
        