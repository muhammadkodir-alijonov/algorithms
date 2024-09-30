from typing import List

class Solution:
    def setZeroes(self, matrix: List[List[int]]) -> None:
        row, col = len(matrix), len(matrix[0])
        # using set is removing duplication zero 
        rows_to_zero = set()
        cols_to_zero = set()

        # First pass to find all rows and columns that need to be zeroed
        for i in range(row):
            for j in range(col):
                if matrix[i][j] == 0:
                    rows_to_zero.add(i)
                    cols_to_zero.add(j)

        # Second pass to set the rows and columns to zero
        for i in range(row):
            for j in range(col):
                if i in rows_to_zero or j in cols_to_zero:
                    matrix[i][j] = 0