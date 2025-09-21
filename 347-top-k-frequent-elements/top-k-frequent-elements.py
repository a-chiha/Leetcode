class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        res = {}
        ans = []
        for i in nums:
            if i not in res:
                res[i] = 1
            else:
                res[i]+=1
        res = dict(sorted(res.items(), key=lambda item: item[1], reverse=True))
        for key,value in res.items():
            if k > 0:
                ans.append(key)
                k-=1
        return ans