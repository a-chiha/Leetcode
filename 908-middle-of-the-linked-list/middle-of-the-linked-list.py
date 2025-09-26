# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def middleNode(self, head: Optional[ListNode]) -> Optional[ListNode]:
        ans = head
        count = 0
        while ans is not None:
            count += 1
            ans = ans.next
        mid = count//2
        cur = head
        while mid > 0:
            cur = cur.next
            mid -= 1
        return cur
        
        


        
