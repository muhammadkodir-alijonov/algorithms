#leetcode 2087 Minimum Cost Homecoming of a Robot in a Grid
class Solution(object):
    def minCost(self, startPos, homePos, rowCosts, colCosts):
        """
        :type startPos: List[int]
        :type homePos: List[int]
        :type rowCosts: List[int]
        :type colCosts: List[int]
        :rtype: int
        """
        res = 0
        if(startPos[0]<=homePos[0]):
            for i in range(startPos[0]+1,homePos[0]):
                res += rowCosts[i]
        else:
            for i in range(homePos[0],startPos[0]-1):
                res += rowCosts[i]

        if(startPos[1]<=homePos[1]):
            for i in range(homePos[0],startPos[0]+1):
                res += colCosts[i]
        else:
            for i in range(startPos[0]-1,homePos[0]):
                res += colCosts[i]
        return res

        