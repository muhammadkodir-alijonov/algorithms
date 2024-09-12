from typing import List

class Solution:
    def countConsistentStrings(self, allowed: str, words: List[str]) -> int:
        counter = {}

        for letter in allowed:
            if letter not in counter:
                counter[letter] = 0
            counter[letter] += 1

        res = 0
        for word in words:
            is_consistent = True
            for char in word:
                if char not in counter:
                    is_consistent = False
                    break
            if is_consistent:
                res += 1

        return res