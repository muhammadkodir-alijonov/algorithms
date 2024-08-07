class Solution:
    def sortColors(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        #nums = [2,0,2,1,1,0]
        #[0,0,1,1,2,2]
        #merge sort
        def merge_sort(nums, left, right):
            if left >= right:
                return
            mid = (left + right) // 2
            merge_sort(nums, left, mid)
            merge_sort(nums, mid + 1, right)
            merge(nums, left, mid, right)
            