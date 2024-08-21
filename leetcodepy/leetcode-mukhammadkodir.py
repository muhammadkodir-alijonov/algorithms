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

if __name__ == "__main__":
    # Test cases
    # Tree:
    #       1
    #      / \
    #     2   3
    #    / \
    #   4   5
    root = Treenode(1)
    root.left = Treenode(2)
    root.right = Treenode(3)
    root.left.left = Treenode(4)
    root.left.right = Treenode(5)
    print(count_leaves(root))  # 3

    # Tree:
    #       1
    #      / \
    #     2   3
    #    / \
    #   4   5
    #  / \
    # 6   7
    root = Treenode(1)
    root.left = Treenode(2)
    root.right = Treenode(3)
    root.left.left = Treenode(4)
    root.left.right = Treenode(5)
    root.left.left.left = Treenode(6)
    root.left.left.right = Treenode(7)
    print(count_leaves(root))  # 4

    # Tree:
    #       1
    #      / \
    #     2   3
    #    / \
    #   4   5
    #  / \
    # 6   7
    #    / \
    #   8   9
    root = Treenode(1)
    root.left = Treenode(2)
    root.right = Treenode(3)
    root.left.left = Treenode(4)
    root.left.right = Treenode(5)
    root.left.left.left = Treenode(6)
    root.left.left.right = Treenode(7)
    root.left.left.right.left = Treenode(8)
    root.left.left.right.right = Treenode(9)
    print(count_leaves(root))  # 5

    # Tree:
    #       1
    #      / \
    #     2   3
    #    / \
    #   4   5
    #  / \
    # 6   7
    #    / \
    #   8   9
    #  / \
    # 10 11

