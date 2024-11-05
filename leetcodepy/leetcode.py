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
