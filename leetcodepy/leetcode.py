def sortSentence(s):
    words = s.split(" ")
    sorted_words = sorted(words, key=lambda word: int(word[-1]))
    result = [word[:-1] for word in sorted_words]
    return " ".join(result)

s = "is2 sentence4 This1 a3"
print(sortSentence(s))
