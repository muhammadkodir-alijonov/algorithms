

def sortArrayByParity(nums):
    even = []
    odd = []
    for i in nums:
        if i % 2 == 0:
            even.append(i)
        else:
            odd.append(i)
    return even + odd

print(sortArrayByParity([3,1,2,4]))