class Solution:
    def findMinDifference(self, timePoints: List[str]) -> int:
        def timeToMinutes(time):
            hours, minutes = map(int, time.split(':'))
            return hours * 60 + minutes

        minutes_list = [timeToMinutes(time) for time in timePoints]

        minutes_list = self.merge_sort(minutes_list)

        min_diff = float('inf')

        for i in range(1, len(minutes_list)):
            min_diff = min(min_diff, minutes_list[i] - minutes_list[i - 1])

        min_diff = min(min_diff, 1440 + minutes_list[0] - minutes_list[-1])

        return min_diff
    def merge_sort(self, arr):
        if len(arr) <= 1:
            return arr

        mid = len(arr) // 2
        left = self.merge_sort(arr[:mid])
        right = self.merge_sort(arr[mid:])

        i = j = 0
        sorted_arr = []
        k = 0
        while i < len(left) and j < len(right):
            if left[i] < right[j]:
                sorted_arr.append(left[i])
                i += 1
            else:
                sorted_arr.append(right[j])
                j += 1
            k += 1
        while i < len(left):
            sorted_arr.append(left[i])
            i += 1
            k += 1
        while j < len(right):
            sorted_arr.append(right[j])
            j += 1
            k += 1
        return sorted_arr