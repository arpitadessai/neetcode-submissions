from collections import Counter

class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        counts = Counter(nums)

        result = any(value > 1 for value in counts.values())

        return result;

        