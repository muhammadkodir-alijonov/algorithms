from collections import Counter

#text = "nlaebolko"

class Solution:
    def maxNumberOfBalloons(self, text: str) -> int:
        balloons_count = {'b': 0, 'a': 0, 'l': 0, 'o': 0, 'n': 0}
        for i in text:
            if i in balloons_count:
                balloons_count[i] +=1
        balloons_count['l'] //=2
        balloons_count['o'] //=2
        
        min_balloons_count = min(balloons_count.values())
        return min_balloons_count