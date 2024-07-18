#Input: n = 19 True

class Solution:
    def isHappy(self, n: int) -> bool:
        korilgan_sonlar = []
        while True:
            digit = n//10
            korilgan_sonlar.append(digit)
            summ += digit**2
            if summ == 1:
                return True
            else:
                continue
        return False
            