class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        map1 = {"]":"[","}":"{",")":"("}

        for i in s:
            if i in map1.values():
                stack.append(i)
            elif stack and map1.get(i,0) == stack[-1]:
                stack.pop()
            else:
                return False
        return len(stack) == 0
        
        