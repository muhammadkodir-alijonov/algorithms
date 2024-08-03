from typing import List

class Solution:
    def canAliceWin(self, nums: List[int]) -> bool:
        summ1 = 0
        summ = 0
        for num in nums:
            if num<=9:
               summ += num
            else:
                summ1 += num
        if summ == summ1:
            return False
        else:
            return True