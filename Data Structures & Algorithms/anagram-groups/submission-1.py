from typing import Dict, List

class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        dict = defaultdict(list)

        for item in strs:
            count = [0] * 26
            for c in item:
                index = ord(c) - ord('a')
                count[index] += 1
            key = tuple(count)
            dict[key].append(item)

        return list(dict.values())       
            
