class Solution(object):
    def maximum69Number (self, num):
        """
        :type num: int
        :rtype: int
        """
        for i in num:
            if i == 6:
                num = num.replace(i, 9, 1)
                break
        return num

print(Solution.maximum69Number(9969))