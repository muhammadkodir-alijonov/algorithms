

def valid_brackets(s: str) -> bool:
    stack = []
    bracka = {")": "(", "]": "[", "}": "{"}
    for char in s:
        if char not in bracka:
            stack.append(char)
        elif not stack or bracka[char] != stack.pop():
            return False
    return not stack


print(valid_brackets("(]"))
