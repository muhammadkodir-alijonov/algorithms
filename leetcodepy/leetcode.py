import itertools
from typing import List

class Solution:
    def permute(self, nums: List[int]) -> List[List[int]]:
        res = list(itertools.permutations(nums))
        return [list(x) for x in res]
        