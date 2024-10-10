from typing import List

class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        if not nums:
            return 0
        left = 0
        right = 0
        sum = 0
        min_len = float("inf")
        while right < len(nums):
            sum += nums[right]
            while sum >= target:
                min_len = min(min_len, right - left + 1)
                sum -= nums[left]
                left += 1
            right += 1
        return min_len if min_len != float("inf") else 0
                