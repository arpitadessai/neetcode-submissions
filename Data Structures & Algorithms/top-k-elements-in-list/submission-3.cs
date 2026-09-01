public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!frequency.ContainsKey(num))
            {
                frequency[num] = 0;
            }

            frequency[num]++;
        }
        
        List<int>[] counts = new List<int>[nums.Length + 1];

        foreach (var kv in frequency)
        {
            if (counts[kv.Value] == null)
            {
                counts[kv.Value] = new List<int>();
            }

            counts[kv.Value].Add(kv.Key);
        }

        //return counts.Where(a => a != null).Skip(nums.Length - k).SelectMany(a => a).ToArray();

        List<int> result = new List<int>();
        for (int i = counts.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (counts[i] != null)
            {
                foreach (int item in counts[i])
                {
                    result.Add(item);

                    if (result.Count == k)
                    {
                        break;
                    }
                }
            }
            
        }

        return result.ToArray();

    }
}
