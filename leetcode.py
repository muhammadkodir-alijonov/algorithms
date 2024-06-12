from typing import List


# Input nums = [0,1,1,1,0,1,1,0,1]
# Output: 5

class Solution:
    def longestSubarray(nums: List[int]) -> int:
        left = 0
        right = 0
        max_len = 0
        num_zeros = 0
        while right < len(nums):
            if nums[right] == 0:
                num_zeros += 1

            while num_zeros > 1:
                if nums[left] == 0:
                    num_zeros -= 1
                left += 1
            max_len = max(max_len, right - left)
            right += 1
        return max_len
    
print(Solution.longestSubarray([0,1,1,1,0,1,1,0,1]))
