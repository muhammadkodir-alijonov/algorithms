class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        hash_map = {}
        start = max_length = 0
        for i in range(len(s)):
            if s[i] in hash_map:
                start = max(start,hash_map[s[i]]+1)
            hash_map[s[i]] = i
            max_length = max(max_length,i-start+1)
        return max_length

print(Solution().lengthOfLongestSubstring("abcabcbb")) # 3