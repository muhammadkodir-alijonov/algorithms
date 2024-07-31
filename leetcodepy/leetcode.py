class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        summ = 0
        n = len(nums)
        for i in range(len(nums)):
            summ += nums[i]
        return n*(n+1)/2 -summ