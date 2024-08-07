class Solution:
    def sortColors(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        #nums = [2,0,2,1,1,0]
        #[0,0,1,1,2,2]
        n = len(nums)
        for i in range(n):
            swapped = False
            for j in range(0,n-i-1):
                if nums[j]>nums[j+1]:
                    nums[j], nums[j + 1] = nums[j + 1], nums[j]
                    swapped = True
            if not swapped:
                break