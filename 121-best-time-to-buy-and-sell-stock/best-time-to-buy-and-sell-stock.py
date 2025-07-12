class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        buyprice = prices[0]
        profit = 0
        for x in prices:
            if buyprice > x:
                buyprice = x
            profit = max(profit,x-buyprice)
        return profit


        
                
