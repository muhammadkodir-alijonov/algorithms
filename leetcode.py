from random import randint


class RandomizedSet:
    def __init__(self):
        """
        Initialize your data structure here.
        """
        self.nums = []
        self.pos = {}

    def insert(self, val: int) -> bool:
        """
        Inserts a value to the set. Returns true if the set did not already contain the specified element.
        """
        if val in self.pos:
            return False
        self.pos[val] = len(self.nums)
        self.nums.append(val)
        return True

    def remove(self, val: int) -> bool:
        """
        Removes a value from the set. Returns true if the set contained the specified element.
        """
        if val not in self.pos:
            return False
        indx = self.pos[val]
        last_val = self.nums[-1]
        self.nums[indx] = self.nums[-1]
        self.pos[self.nums[-1]] = indx
        self.nums.remove(last_val)
        del self.pos[val]
        return True
    
    def getRandom(self) -> int:
        """
        Get a random element from the set.
        """
        return self.nums[randint(0, len(self.nums) - 1)]


# Your RandomizedSet object will be instantiated and called as such:
obj = RandomizedSet()
param_1 = obj.insert(1)
param_2 = obj.remove(11)
param_3 = obj.getRandom()
print(param_1, param_2, param_3)
