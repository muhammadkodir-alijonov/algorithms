#sliding window algorithms
def slidingwindow(arr, k):
    n = len(arr)
    if n < k:
        return []
    result = []
    window_sum = sum(arr[:k])
    result.append(window_sum)
    for i in range(n-k):
        window_sum = window_sum - arr[i] + arr[i+k]
        result.append(window_sum)
    return result