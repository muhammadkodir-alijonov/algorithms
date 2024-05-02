class Solution(object):
    def threeSumClosest(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: int
        """
        nums.sort()
        closest = float('inf')
        for i in range(len(nums) - 2):
            if i > 0 and nums[i] == nums[i - 1]:
                continue
            left, right = i + 1, len(nums) - 1
            while left < right:
                total = nums[i] + nums[left] + nums[right]
                if total == target:
                    return total
                if abs(total - target) < abs(closest - target):
                    closest = total
                if total < target:
                    left += 1
                else:
                    right -= 1
        return closest
print(Solution().threeSumClosest([-1, 2, 1, -4], 1))  # 2