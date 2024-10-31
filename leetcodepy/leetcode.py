from typing import List

class Solution:
<<<<<<< HEAD
    def hIndex(self, citations: List[int]) -> int:
        pass
=======
    def canJump(self, nums: List[int]) -> bool:
        farthest = 0
        for i in range(len(nums)):
            if i > farthest:
                return False
            farthest = max(farthest, i + nums[i])
        return True

print(Solution().canJump([2,1,1,0,4])) # True
>>>>>>> 11ff87fc4f809355910c3ecfbc1fe9e665e75688
