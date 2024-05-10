from collections import Counter, defaultdict


def build_counter(word):
    counter = defaultdict(int)
    for char in word:
        counter[char] += 1
    return counter


def is_anagram(word1, word2) -> bool:
    counter = build_counter(word1)
    for char in word2:
        counter[char] -= 1
    for value in counter.values():
        if value != 0:
            return False
    return True


print(is_anagram("anagram", "nagaram"))  # True

my_string = "codingiscool1"
are_there_digits = [char.isdigit() for char in my_string]
print(any(are_there_digits))

