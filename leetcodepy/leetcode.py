class Solution:
    def maximumSwap(self, num: int) -> int:
        str_num = list(str(num))
        n = len(str_num)
        max_idx = n - 1
        x, y = -1, -1

        for i in range(n - 1, -1, -1):
            if str_num[i] > str_num[max_idx]:
                max_idx = i
            elif str_num[i] < str_num[max_idx]:
                x, y = i, max_idx

        if x != -1:
            str_num[x], str_num[y] = str_num[y], str_num[x]

        return int(''.join(str_num))