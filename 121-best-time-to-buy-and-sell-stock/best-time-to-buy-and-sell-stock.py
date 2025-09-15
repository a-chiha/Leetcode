class Solution:
    def maxProfit(self, nums: List[int]) -> int:
        cur_min = nums[0]
        max_profit = 0
        for i in range(len(nums)):
            profit = nums[i]-cur_min
            if profit > max_profit:
                max_profit = profit
            if nums[i] < cur_min:
                cur_min = nums[i]
        return max_profit




        
                
