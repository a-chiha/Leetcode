class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        j = 0
        window = set()
        
        for i in range(len(nums)): 
            if i - j > k:
                window.remove(nums[j])
                j+=1
            if nums[i] in window:
                return True
            window.add(nums[i])

        return False

