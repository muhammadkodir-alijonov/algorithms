from typing import List
#Input: nums = [1,2,3,4]
#Output: [24,12,8,6]
class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
#simple solution with O(n) time complexity and O(n) space complexity with prefic and suffix arra
        n = len(nums)
        pref = [1]*n
        suff = [1]*n
        for i in range(1,n):
            pref[i] = pref[i-1]*nums[i-1]
        for i in range(n-2,-1,-1):
            suff[i] = suff[i+1]*nums[i+1]
        for i in range(n):
            nums[i] = pref[i]*suff[i]
        return nums
