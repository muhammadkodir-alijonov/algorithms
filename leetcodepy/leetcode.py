from typing import List
# n = 5
#[-2,-1,0,1,2].
class Solution:
    def sumZero(self, n: int) -> List[int]:
        sum_zero = []
        if n%2 != 0:
            sum_zero.append(0)
        for i in range(1,n//2+1):
            sum_zero.append(i)
            sum_zero.append(-i)
        return sum_zero