class Solution:
    def maxArea(self, height: List[int]) -> int:
        j = len(height)-1
        maxw = 0
        i = 0
        while i < j:
            if height[i] < height[j]:
                if maxw < height[i]*(j-i):
                    maxw = height[i]*(j-i)
            else:
                if maxw < height[j]*(j-i):
                    maxw = height[j]*(j-i)
            if height[i] < height[j]:
                i += 1
            else:
                j -= 1
        return maxw
        
        
        
        
        
            

           
        