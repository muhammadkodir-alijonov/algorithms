class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        char_dict = {}
        start = max_length = 0
        for i in range(len(s)):
            if s[i] in char_dict:
                start = max(start, char_dict[s[i]] + 1)
            char_dict[s[i]] = i
            max_length = max(max_length, i - start + 1)
        return max_length
    
print(Solution().lengthOfLongestSubstring("acabcbb"))  # 3