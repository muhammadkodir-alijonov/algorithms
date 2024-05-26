from typing import List

class Solution:
    def compress(self, chars: List[str]) -> List[str]:
        r, i = 0, 0  # r va i indekslarni 0 ga teng qilib boshlaymiz
        while i < len(chars):  # i 'chars' ro'yxatining oxirigacha yurar ekan
            currChar = chars[i]  # hozirgi harfni olamiz
            currOcc = 0  # hozirgi harfning ketma-ket kelgan sonini hisoblash uchun
            while i < len(chars) and chars[i] == currChar:  # hozirgi harf ketma-ket kelayotgan bo'lsa
                currOcc += 1  # sanog'ini oshiramiz
                i += 1  # keyingi harfga o'tamiz
            chars[r] = currChar  # r indeksiga hozirgi harfni qo'yamiz
            r += 1  # r indeksini bitta oshiramiz
            if currOcc > 1:  # agar hozirgi harf bir marta ko'p kelsa
                currOccStr = str(currOcc)  # kelgan sonini stringga aylantiramiz
                for j in range(len(currOccStr)):  # bu stringning har bir belgisini
                    chars[r] = currOccStr[j]  # r indeksiga qo'yamiz
                    r += 1  # r indeksini oshiramiz
        return chars[str]  # ro'yxatning yangi uzunligini qaytaramiz

print(Solution().compress(["a","a","b","b","c","c","c"]) == 6)