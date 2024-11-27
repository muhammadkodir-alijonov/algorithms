from inspect import stack
from itertools import count


class Solution:
    def decodeString(self, s: str) -> str:
        stack = []  # Stack to store previous substrings and counts
        current_str = ""  # Current decoded string
        current_num = 0  # To handle the number before `[`

        for char in s:
            if char.isdigit():  # If the character is a digit
                current_num = current_num * 10 + int(char)  # Build the number
            elif char == '[':  # If `[` is encountered, push current values onto stack
                stack.append((current_str, current_num))
                current_str = ""  # Reset the current string
                current_num = 0  # Reset the number
            elif char == ']':  # If `]` is encountered, pop from stack and repeat the string
                last_str, num = stack.pop()
                current_str = last_str + current_str * num  # Repeat the current string `num` times
            else:  # If the character is a letter, add it to the current string
                current_str += char

        return current_str  # Return the final decoded string