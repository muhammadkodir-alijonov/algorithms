#leetocde 905. Sort Array By Parity
class Solution(object):
    def sortArrayByParity(self, nums):
        """
        :type nums: List[int]
        :rtype: List[int]
        """
        left = 0
        right = len(nums) - 1
        while(left<right):
            if nums[left] % 2 == 0:
                left += 1
            else:
                nums[left], nums[right] = nums[right], nums[left]
                right -= 1
        return nums
print(Solution().sortArrayByParity([3,1,2,4]))