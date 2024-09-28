from typing import Optional

class ListNode:
    def __init__(self, x, next=None):
        self.val = x
        self.next = next

def removeNthFromEnd(head: ListNode, n: int) -> ListNode:
    # Dummy node to simplify edge cases (e.g., removing the first node)
    dummy = ListNode(0)
    dummy.next = head

    fast = dummy
    slow = dummy

    # 1. Fast pointerni oldinga n qadam yuritamiz
    for _ in range(n):
        fast = fast.next

    # 2. Ikkala pointerni oxirigacha bir vaqtda yuritamiz
    while fast.next:
        fast = fast.next
        slow = slow.next

    # 3. Sekin pointerni olib tashlash kerak bo'lgan elementga yetkazamiz
    slow.next = slow.next.next

    # 4. Ro'yxatning yangi boshini qaytarish
    return dummy.next

            