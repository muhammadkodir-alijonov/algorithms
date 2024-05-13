

def valid_brackets(s: str) -> bool:
    stack = []
    bracka = {")": "(", "]": "[", "}": "{"}
    for char in s:
        if char not in bracka:
            stack.append(char)
            continue
        if not stack:
            return False
        last_opened = stack.pop()
        if last_opened != bracka[char]:
            return False
    return not stack


print(valid_brackets("({[})"))
