from typing import List
class Solution:
    def findScore(self, nums: List[int]) -> int:
        # faqat + numlar ekan
        # score = 0 dan boshlanadi ekan
        # mark qilinmagan smallest num ni qidirish kerak
        # add score endi u mavjud bo'lsa uni qo'shnilarni mark qilib qo'yamiz
        # repeat qilamiz hammasi mark bo'maguncha
        score = 0
        n = len(nums)
        visited = [False for _ in range(n)]
        for i in range(1,n):
            k = n
            min_ = min(nums)
            if not visited[i]:
                visited[i] = True
                score += min_
                if n<0 and not visited[i+1] and not visited[i-1]:
                    visited[i-1],visited[i+1] = True, True

        return score