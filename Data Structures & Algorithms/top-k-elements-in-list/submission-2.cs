public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (!counts.ContainsKey(item))
            {
                counts[item] = 1;
            }
            else
            {
                counts[item] = counts[item] + 1;
            }
        }

        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

        foreach (var kv in counts)
        {
            priorityQueue.Enqueue(kv.Key, kv.Value);

            if (priorityQueue.Count > k)
            {
                priorityQueue.Dequeue();
            }
        }

        int[] result = new int[k];
        for (int i = 0; i < k; i++)
        {
            result[i] = priorityQueue.Dequeue();
        }

        return result;

    }
}
