
def sum_recursion(nums: list[int], index = 0) -> int:
    if index == len(nums):
        return 0
    return nums[index] + sum_recursion(nums, index + 1)


print(sum_recursion([1, 2, 3]))
