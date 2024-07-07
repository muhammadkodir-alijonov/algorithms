class Solution:
    def numWaterBottles(self, numBottles: int, numExchange: int) -> int:
        summ = numBottles
        while numBottles >= numExchange:
            new_b = numBottles//numExchange
            summ += new_b
            numBottles = new_b + numBottles%numExchange
        return summ