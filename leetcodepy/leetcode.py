class Solution:
    def countPrimes(self, n: int) -> int:
        if n <= 2:
            return 0

        # 1. Prime boolean ro'yxatini yaratamiz
        is_prime = [True] * n
        is_prime[0] = is_prime[1] = False  # 0 va 1 tub son emas

        # 2. 2 dan boshlab, barcha ko'paytmalarini belgilash
        for i in range(2, int(n ** 0.5) + 1):
            if is_prime[i]:
                for j in range(i * i, n, i):
                    is_prime[j] = False

        # 3. True bo'lganlarni sanaymiz (tub sonlar)
        return sum(is_prime)
