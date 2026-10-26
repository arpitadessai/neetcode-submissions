public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        foreach (char c in s)
        {
            int existing = 0;
            if (charCounts.ContainsKey(c))
            {
                existing = charCounts[c];
            }

            charCounts[c] = existing + 1;
        }

        foreach (char c in t)
        {
            if (charCounts.TryGetValue(c, out int existing) && existing > 0)
            {
                charCounts[c] = existing - 1;
            }
            else
            {
                return false;
            }
        }

        foreach (var item in charCounts)
        {
            if (item.Value > 0)
            {
                return false;
            }
        }

        return true;

    }
}
