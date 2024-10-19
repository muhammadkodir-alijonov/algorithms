class Solution:
    def checkPerfectNumber(self, num: int) -> bool:
        if num<=1:
            return False
        count = 1
        my_sqrt = int(num**0.5)
        for i in range(2,my_sqrt+1):
            if num%i == 0:
                count += i
                if i != num//i:
                    count += num//i
        return count == num
    
print(Solution().checkPerfectNumber(28)) # True