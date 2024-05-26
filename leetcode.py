class Solution:
    def mySqrt(self, x: int) -> int:
        left , right = 1, x
        while left <= right:
            mid = (left + right)//2
            m_sqrt = mid * mid
            if m_sqrt == x:
                return mid
            elif m_sqrt < x:
                left = mid + 1
            else:
                right = mid - 1
        return right
    
print(Solution().mySqrt(4))