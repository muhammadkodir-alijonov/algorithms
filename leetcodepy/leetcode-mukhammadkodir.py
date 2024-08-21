from typing import Deque

class Treenode:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None
def is_leaf(node):
    return not node.left and not node.right

def count_leaves(root:Treenode) -> int:
    total = 0
    queue = Deque[root]
    
    while queue:
        curr = queue.pop()
        if not curr:
            continue
        if is_leaf(curr):
            total += 1
        queue.appendleft(curr.left)
        queue.appendleft(curr.right)
    return total