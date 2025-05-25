class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        numstring = ""
        for i in digits:
            numstring+=str(i) 
        numresult = int(numstring) +1
        return [int(x) for x in str(numresult)]




 
