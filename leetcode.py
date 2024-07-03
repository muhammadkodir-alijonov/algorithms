from typing import List

class Solution:
    def minDifference(self, nums: List[int]) -> int:
        n = len(nums)
        if n <= 4:
            return 0
        nums.sort()
        
        case1 = nums[n-4] - nums[0]
        case2 = nums[n-3] - nums[1]
        case3 = nums[n-2] - nums[2]
        case4 = nums[n-1] - nums[3]
        
        return min(case4,case3,case2,case1)
    
print(Solution().minDifference([1,5,0,10,14])) # 1
        