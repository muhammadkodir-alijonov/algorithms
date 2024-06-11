class Solution:
    def maxVowels(s: str, k: int) -> int:
        vowels = set("aeiou")  # Unli harflarni to'plamga aylantiramiz
        n = len(s)
        count_vowels = 0

        # Dastlabki k uzunlikdagi substringdagi unli harflarni sanaymiz
        for i in range(k):
            if s[i] in vowels:
                count_vowels += 1

        max_vowels = count_vowels

        # Slayd qiluvchi oyna usulini qo'llaymiz
        for i in range(k, n):
            if s[i - k] in vowels:
                count_vowels -= 1
            if s[i] in vowels:
                count_vowels += 1
            max_vowels = max(max_vowels, count_vowels)

        return max_vowels
    

print(Solution.maxVowels("abciiidef",3))