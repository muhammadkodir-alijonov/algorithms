import random

class RandomizedSet:

    def __init__(self):
        self.lst = []
        self.map = {}

    def insert(self, val: int) -> bool:
        if val in self.map:
            return False

        self.lst.append(val)
        self.map[val] = len(self.lst) - 1
        return True

    def remove(self, val: int) -> bool:
        if not val in self.map:
            return False

        val_idx = self.map[val]
        self.lst[val_idx] = self.lst[-1]
        self.map[self.lst[-1]] = val_idx
        self.lst.pop()
        del self.map[val]
        return True

    def getRandom(self) -> int:
        return random.choice(self.lst)