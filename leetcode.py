from typing import List

class Solution:
    def largestAltitude(self, gain: List[int]) -> int:
        n = len(gain)
        prefix_sum = [0]*(n+1)
        for i in range(1, n+1):
            prefix_sum[i] = prefix_sum[i-1] + gain[i-1]
        max_sum = max(prefix_sum)
        return max_sum


print(Solution().largestAltitude([-5,1,5,0,-7]))    