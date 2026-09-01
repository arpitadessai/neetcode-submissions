class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        counts = Counter(nums)

        sorted_counts = sorted(counts.items(), key=lambda x: x[1], reverse=True)

        result = [item for item, freq in sorted_counts[:k]]

        return result