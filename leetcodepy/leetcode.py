class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def pairSum(head):
    # 1. Linked listning uzunligini hisoblash
    length = 0
    current = head
    while current:
        length += 1
        current = current.next

    # 2. Tugunlarning qiymatlarini listga saqlash
    values = []
    current = head
    while current:
        values.append(current.val)
        current = current.next

    # 3. Twin sum va max_sum ni topish
    max_sum = 0
    for i in range(length // 2):
        twin_sum = values[i] + values[length - 1 - i]
        max_sum = max(max_sum, twin_sum)

    return max_sum
