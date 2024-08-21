from collections import deque

class Treenode:
    def __init__(self, val):
        self.val = val
        self.left = None
        self.right = None

def is_leaf(node):
    return not node.left and not node.right

def dfs(root:Treenode) -> int:
    stack = []
    curr = root
    while stack or curr:
        while curr:
            stack.append(curr)
            curr = curr.left
        curr = stack.pop()
        print(curr.val)
        curr = curr.right