public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach (int item in nums)
        {
            minHeap.Enqueue(item, item);

            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        return minHeap.Peek();
    }
}
