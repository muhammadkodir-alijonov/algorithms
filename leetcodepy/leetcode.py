from typing import List

class Solution:
    def generateMatrix(self, n: int) -> List[List[int]]:
        #simple solution
        matrix = [[0] * n for _ in range(n)]
        row_start, row_end = 0, n - 1
        col_start, col_end = 0, n - 1
        num = 1

        while row_start <= row_end and col_start <= col_end:
            for i in range(col_start, col_end + 1):
                matrix[row_start][i] = num
                num += 1
            row_start += 1

            for i in range(row_start, row_end + 1):
                matrix[i][col_end] = num
                num += 1
            col_end -= 1

            if row_start <= row_end:
                for i in range(col_end, col_start - 1, -1):
                    matrix[row_end][i] = num
                    num += 1
                row_end -= 1

            if col_start <= col_end:
                for i in range(row_end, row_start - 1, -1):
                    matrix[i][col_start] = num
                    num += 1
                col_start += 1

        return matrix
#time complexity is O(n^2) and space complexity is O(n^2)
# Runtime: 32 ms, faster than 61.83% of Python3 online submissions for Spiral Matrix II.