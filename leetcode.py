from typing import List

class Solution:
    def kidsWithCandies(candies: List[int], extraCandies: int) -> List[bool]:
        max_candies = max(candies)
        return [candy + extraCandies >= max_candies for candy in candies]
    
print(Solution.kidsWithCandies([2,3,5,1,3],3))