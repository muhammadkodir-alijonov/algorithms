class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        #solve with dic
        dic = {}
        for i in s:
            if i in dic:
                dic[i] += 1
            else:
                dic[i] = 1
        for i in t:
            if i in dic:
                dic[i] -= 1
                if dic[i] == 0:
                    del dic[i]
            else:
                return False
        return not dic

print(Solution().isAnagram("anagram", "nagaram")) # True