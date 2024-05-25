from typing import List


class Solution:
    def increasingTriplet(self, nums: List[int]) -> bool:
        small = medium = int('inf')
        for num in nums:
            if num <= small:
                small = num
            elif num <= medium:
                medium = num
            else:
                return True
        return False
