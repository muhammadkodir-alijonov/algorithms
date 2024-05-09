class Node:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def reverse(head):
    pre = None
    curr = head
    while curr is not None:
        next_ = curr.next
        pre = curr
        curr = next_
    return pre
print(reverse(Node(1, Node(2, Node(3, Node(4))))).val)


