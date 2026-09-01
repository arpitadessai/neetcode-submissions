from collections import Counter

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        sameChars = set(s) == set(t)

        s_count = Counter(s)
        t_count = Counter(t)

        sameCount = s_count == t_count

        return sameChars and sameCount
        