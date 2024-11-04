class Solution:
    def balancedStringSplit(self, s: str) -> int:
        x,y=0
        count = 0
        n = len(s)
        for i in range(1,n):
            if i == 'R':
                x+=1
                if x == y:
                    count += 1
            else:
                y+=1
                if x == y:
                    count +=1 
        return count
                