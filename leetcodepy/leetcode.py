# Definition for a binary tree node.
from typing import Optional, List
from collections import deque

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        ans = []
        queue = deque([root])
        if root is None:
            return []
        while queue:
            n = len(queue)
            for i in range(0, n-1):
                node = queue.popleft()
                if node.left:
                    queue.append(node.left)
                elif node.right:
                    queue.append(node.right)
                elif i == n-1:
                    ans.append(node.val)
        return ans