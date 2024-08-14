class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        it = iter(t)
        for char in s:
            if char in it:
                return all(char)
        return False