from typing import List

class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        res = 0
        for i in range(len(nums)):
            if nums[i] != val:
                nums[res] = nums[i]
                res+=1
        return res
    
print(Solution().removeElement([0,1,2,2,3,0,4,2], 2))   