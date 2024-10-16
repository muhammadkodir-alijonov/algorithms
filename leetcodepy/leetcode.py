class Solution(object):
    def checkPerfectNumber(self, num):
        """
        :type num: int
        :rtype: bool
        """
        if num <= 1:
            return False
        count = 1
        sqrt_num = int(num**0.5)
        for i in range(2, sqrt_num+1):
            if num%i == 0:
                count+=i
                if i != num//i:
                    count+=num//i
        return count == num


num = 28
solution = Solution()
print(solution.checkPerfectNumber(num))
