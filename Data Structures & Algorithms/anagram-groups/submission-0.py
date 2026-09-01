from typing import Dict, List

class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        dict = defaultdict(list)

        for item in strs:
            item_sorted = "".join(sorted(item))

            dict[item_sorted].append(item)
            
        return list(dict.values())
