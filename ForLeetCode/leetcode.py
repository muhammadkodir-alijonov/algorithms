# 1. three Sum
nums = [-1, 0, 1, 2, -1, -4]
def threesum(nums):
    res = set()
    nums.sort()
    for i in range(len(nums)-2):
        for j in range(i+1,len(nums)-1):
            for k in range(j+1,len(nums)):
                if nums[i]+nums[j]+nums[k] == 0:
                    res.add((nums[i],nums[j],nums[k]))
    return [list(triplet) for triplet in res]
print(threesum(nums))    
