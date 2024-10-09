class Solution:
    def minAddToMakeValid(self, s: str) -> int:
        ochiq = 0  # Yopilmagan ochiq qavslar soni
        qoshimcha = 0  # Qo'shish kerak bo'lgan qavslar soni
        for qavs in s:
            if qavs == '(':
                ochiq += 1  # Yopilishini kutayotgan ochiq qavslar soni oshadi
            else:
                if ochiq > 0:
                    ochiq -= 1  # Yopilayotgan ochiq qavs
                else:
                    qoshimcha += 1  # Noto'g'ri yopiq qavs bo'lsa, ochiq qavs qo'shish kerak bo'ladi
        return qoshimcha + ochiq  # Yopilmagan ochiq qavslar sonini qo'shamiz

print(Solution().minAddToMakeValid("((())"))