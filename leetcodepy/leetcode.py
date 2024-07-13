class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        hash_tabel = {}
        start = max_length = 0
        for i in range(len(s)):
            if s[i] in hash_tabel:
                start = max(start,hash_tabel[s[i]+1])
            hash_tabel[s[i]] = 1
            max_length = max(max_length,i-start+1)
        return max_length