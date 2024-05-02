#twu sum
# 1. Two Sum
nums = [2, 7, 11, 15]
target = 9

def twosum(nums,target):
    for i in range(len(nums)):
        for j in range(i+1,len(nums)):
            if nums[i]+nums[j]==target:
                return [i,j]
            return None
print(twosum(nums,target))