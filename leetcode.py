from typing import List

class Solution:
    def findMaxAverage(nums: List[int], k: int) -> float:
        window = sum(nums[:k])
        max_sum = window
        for i in range(k, len(nums)):
            window += nums[i] - nums[i-k]
            max_sum = max(max_sum, window)
        return max_sum / k
    
print(Solution.findMaxAverage([1,2,3,4,-1,4,9,0],4))