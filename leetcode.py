from typing import List

class Solution:
    def minOperations(self, logs: List[str]) -> int:
        stack = []
        for log in logs:
            if log == '../':
                if stack:
                    stack.pop()
            elif log != './':
                stack.append(log)
        return len(stack)

<<<<<<< HEAD
#commit + commit
=======
#commit
>>>>>>> c80cde983485ab6507749567b7cfc4e02d2951fb
