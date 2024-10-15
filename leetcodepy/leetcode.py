from typing import List

class Solution:
    def rob(self, nums: List[int]) -> int:
        if not nums:
            return 0
        if len(nums) == 1:
            return nums[0]
        if len(nums) == 2:
            return max(nums)
        return max(self.rob(nums[1:]), self.rob(nums[:-1]))

print(Solution().rob([2,7,9,2,1])) 

