#twu sum
# 1. Two Sum
def twoSum(nums, target):
    dict = {}
    for i in range(len(nums)):
        if target - nums[i] in dict:
            return [dict[target - nums[i]], i]
        dict[nums[i]] = i
    return None
nums = [2, 7, 11, 15]
target = 9
print(twoSum(nums, target))