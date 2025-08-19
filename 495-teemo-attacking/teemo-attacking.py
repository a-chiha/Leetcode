class Solution:
    def findPoisonedDuration(self, timeSeries: List[int], duration: int) -> int:
        output = 0
        n = len(timeSeries)
        for i in range(n-1):
            output += min(timeSeries[i+1] - timeSeries[i],duration)
        return output + duration
            