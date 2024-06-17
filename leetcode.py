class Solution:
    def halvesAreAlike(self, s: str) -> bool:
        i = 0
        j = len(s) - 1
        mid = 0
        vowels = set('aeiouAEIOU')
        while i < j:
            if s[i] in vowels:
                mid += 1
            if s[j] in vowels:
                mid -= 1
            i += 1
            j -= 1

        return mid == 0
