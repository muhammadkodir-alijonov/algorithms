class TreeNode(object):
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution(object):
    def rangeSumBST(self, root, low, high):
        """
        :type root: TreeNode
        :type low: int
        :type high: int
        :rtype: int
        """
        def dfs(node):
            if not node:
                return 0
            if node.val < low:
                return dfs(node.right)
            if node.val > high:
                return dfs(node.left)
            return node.val + dfs(node.left) + dfs(node.right)
        return dfs(root)