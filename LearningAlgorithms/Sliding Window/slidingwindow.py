from typing import List
#prices = [7,1,5,3,6,4]
#output = 5
class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        min_price = float('inf')
        max_profit = 0
        for i in prices:
            if min_price > i:
                min_price = i
            elif i - min_price > max_profit:
                max_profit = i - min_price
        return max_profit
    
prices = [7,1,5,3,6,4]
sol = Solution()
sol.maxProfit(prices)
print(sol.maxProfit(prices))
