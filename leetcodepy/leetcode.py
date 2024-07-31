from typing import List

class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        r_list = []
        for i in range(0, numRows):
            row = []
            for j in range(0, i+1):
                if j == 0 or j == i:
                    row.append(1)
                else:
                    row.append(r_list[i-1][j-1] + r_list[i-1][j])
            r_list.append(row)
        return r_list

print(Solution().generate(5))