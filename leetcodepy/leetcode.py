class Solution:
    def isSumEqual(self, firstWord: str, secondWord: str, targetWord: str) -> bool:
        1 = int(self.convertToOrd(firstWord))
        2 = int(self.convertToOrd(secondWord))
        3 = int(self.convertToOrd(targetWord))
        return 1 + 2 == 3
        
        
    def convertToOrd(self,string: str) -> str:
        new_str = ""
        for i in string:
            new_str += str(ord(i)-97)
        return new_str



from typing import List
class Solution:
    def hIndex(self, citations: List[int]) -> int:
        citations.sort(reverse=True)
        h_index = 0
        for i,citation in enumerate(citations):
            if citation > i+1:
                h_index = i+1
            else:
                break
        return h_index


from typing import List

class Solution:
    def largestCombination(self, candidates: List[int]) -> int:
        # Faqat bitta palindrom son qoldirib yangilangan ro'yxat yaratamiz
        unique_palindroms = [1] * 32
        for candidate in candidates:
            for i in range(32):
                if candidate & (1 << i):
                    bit_count[i] += 1
        return max(bit_count)



from typing import List

class Solution:
    def getMaximumXor(self, nums: List[int], maximumBit: int) -> List[int]:
        res = []
        total_xor = 0
        n = len(nums)
        for i in range(n):
            total_xor ^= nums[i]
        max_k = (1<<maximumBit)-1
        for i in range(n-1,-1,-1):
            res.append(total_xor^max_k)
            max_k ^= nums[i]
        return res


class Solution:
    def getMaximumXor(self, nums: List[int], maximumBit: int) -> List[int]:
        ans = []
        mask = (1<<maximumBit) - 1
        for i in range(len(nums)):
            mask = mask ^ nums[i]
            ans.append(mask)
        return ans[::-1]



from typing import List

class Solution:
    def maximumBeauty(items: List[List[int]], queries: List[int]) -> List[int]:
        items.sort()
        
        max_beauty = 0
        for i in range(len(items)):
            max_beauty = max(max_beauty, items[i][1]) 
            items[i][1] = max_beauty

        ans = []
        
        for q in queries:
            left, right = 0, len(items) - 1
            best_beauty = 0
            while left <= right:
                mid = (left + right) // 2
                if items[mid][0] <= q:
                    best_beauty = items[mid][1] 
                    left = mid + 1 
                else:
                    right = mid - 1 
            ans.append(best_beauty)
        
        return ans

print(Solution.maximumBeauty([[1,2],[3,2],[2,4],[5,6],[3,5]],[1,2,3,4,5,6]))



from typing import List

class Solution:
    def decrypt(code: List[int], k: int) -> List[int]:
        if k>0:
            final = code + code[:k]
            for i in range(len(code)):
                code[i] = sum(final[i+1,k+1+i])
            return code
        if k==0:
            new=[0]*len(code)
            return new
        else:
            final = code[k:] + code
            for i in range(len(code)):
                code[i] = sum(final[i:i-k])
            return code
        
print(Solution.decrypt([5,7,1,4],3))





from typing import List
from collections import Counter

class Solution:
    def maximumSubarraySum(self, nums: List[int], k: int) -> int:
        # Dastlabki oyna
        window_map = Counter(nums[:k])
        window_sum = sum(nums[:k])
        max_window_sum = 0  # Default qiymat 0 (agar shart bajarilmasa)

        # Agar birinchi oyna unikal bo'lsa, max_window_sum ni yangilash
        if len(window_map) == k:
            max_window_sum = window_sum

        # Slayding oynani yuritish
        for i in range(len(nums) - k):
            # Chap tomondan elementni olib tashlash
            left_element = nums[i]
            window_map[left_element] -= 1
            if window_map[left_element] == 0:
                del window_map[left_element]
            window_sum -= left_element

            # O'ng tomondan yangi elementni qo'shish
            right_element = nums[i + k]
            window_map[right_element] += 1
            window_sum += right_element

            # Maksimal yig'indini yangilash faqat unikal elementlar uchun
            if len(window_map) == k:  # Agar oyna unikal elementlardan iborat bo'lsa
                max_window_sum = max(max_window_sum, window_sum)

        return max_window_sum







                
