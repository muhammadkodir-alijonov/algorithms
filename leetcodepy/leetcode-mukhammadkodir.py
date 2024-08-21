from collections import deque

class Treenode:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None

def is_leaf(node):
    return not node.left and not node.right

def count_leaves(root: Treenode) -> int:
    total = 0
    queue = deque([root])

    while queue:
        curr = queue.pop()
        if not curr:
            continue
        if is_leaf(curr):
            total += 1
        queue.appendleft(curr.left)
        queue.appendleft(curr.right)
    return total

# Example usage:
root = Treenode(3)
root.left = Treenode(9)
root.right = Treenode(20)
root.right.left = Treenode(15)
root.right.right = Treenode(7)

print(count_leaves(root)) # 3