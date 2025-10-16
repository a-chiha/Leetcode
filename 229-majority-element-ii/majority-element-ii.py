class Solution:
    def majorityElement(self, nums: List[int]) -> List[int]:
        map1 = {}
        ans = []
        for i in nums:
            if i not in map1:
                map1[i] = 1
            else:
                map1[i] +=1
        for k,v in map1.items():
            if v > len(nums)//3:
                ans.append(k)
        return ans

        