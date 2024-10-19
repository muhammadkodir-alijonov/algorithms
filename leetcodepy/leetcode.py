from typing import List

class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        list = []
        for i in nums:
            if i in list:
                list.remove(i)
            else:
                list.append(i)
        return list[0]