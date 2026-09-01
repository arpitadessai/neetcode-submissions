class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        seen = {}

        for i, current_item in enumerate(nums):
            diff = target - current_item

            if diff in seen:
                return [seen[diff], i]
            
            seen[current_item] = i
