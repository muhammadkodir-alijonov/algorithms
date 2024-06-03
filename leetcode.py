from typing import List

class Solution:
    def compress(self, chars: List[str]) -> int:
        n = len(chars)
        if n == 1:
            return 1

        i = 0
        j = 0

        while i < n:
            count = 1
            while i + 1 < n  and chars[i] == chars[i+1]:
                count += 1
                i += 1

            chars[j] = chars[i]
            j += 1

            if count > 1:
                for c in str(count):
                    chars[j] = c
                    j += 1

            i += 1

        return j
    
    
print(Solution().compress(["a","a","b","b","c","c","c"])) # 6