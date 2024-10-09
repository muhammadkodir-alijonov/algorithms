class Solution:
    def minAddToMakeValid(self, s: str) -> int:
        stack = []  # Stack ochiq qavslar uchun
        count = 0  # Qo'shimcha qavslar soni

        for qavs in s:
            if qavs == '(':
                stack.append(qavs)  # Ochiq qavsni stackga qo'shamiz
            else:  # Agar yopiq qavs bo'lsa
                if stack:
                    stack.pop()  # Ochiq qavsni yopamiz (stackdan olib tashlaymiz)
                else:
                    count += 1  # Noto'g'ri yopiq qavs, ochiq qavs kerak bo'lad
        return count + len(stack)
    
print(Solution().minAddToMakeValid("())"))  # 1
