from typing import List

class Solution:
    def jump(self, nums: List[int]) -> int:
        n = len(nums)
        if n == 1:
            return 0

        jumps = 0
        farthest = 0
        currentJumpEnd = 0

        for i in range(n - 1):
            # Eng uzoq erishish mumkin bo'lgan indeksni yangilab boramiz
            farthest = max(farthest, i + nums[i])

            # Agar hozirgi sakrash oxiriga yetgan bo'lsa
            if i == currentJumpEnd:
                jumps += 1
                currentJumpEnd = farthest

        return jumps
print(Solution().jump([2,3,1,1,4])) # 2