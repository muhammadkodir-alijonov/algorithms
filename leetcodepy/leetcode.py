from typing import List

class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        length = len(nums)
        ans = [0]*length
        
        left_p = 1
        for i in range(length):
            ans[i] = left_p
            left_p *= nums[i]
        right_p = 1
        for i in range(length-1,-1,-1):
            ans[i] *= right_p
            right_p *= nums[i]
        return ans