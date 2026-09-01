from collections import Counter

class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        nums.sort()

        counts = Counter(nums)

        result = any(value > 1 for value in counts.values())

        return result;

        