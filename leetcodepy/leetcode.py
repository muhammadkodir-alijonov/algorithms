from typing import Optional
import math

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def insertGreatestCommonDivisors(self, head: Optional[ListNode]) -> Optional[ListNode]:
        curr = head

        # Traverse the linked list
        while curr and curr.next:
            # Find the GCD of the current node and the next node
            # 18 24 36
            gcd_value = self.ekub(curr.val, curr.next.val)

            # Create a new node with the GCD value
            new_node = ListNode(gcd_value)

            # Insert the new node between curr and curr.next
            new_node.next = curr.next
            curr.next = new_node

            # Move to the next pair (skip over the newly inserted node)
            curr = new_node.next

        return head

    # GCD function (Euclidean algorithm)
    def ekub(self, a: int, b: int) -> int:
        if b == 0:
            return a
        else:
            return self.ekub(b, a % b)
