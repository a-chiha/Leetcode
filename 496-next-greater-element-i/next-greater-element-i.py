class Solution:
    def nextGreaterElement(self, nums1: List[int], nums2: List[int]) -> List[int]:
        ans = []
        for i in nums1:
            index = nums2.index(i)
            for j in range(index + 1 ,len(nums2)):
                if nums2[j] > i:
                    ans.append(nums2[j])
                    break
            else:
                ans.append(-1)
        return ans
        