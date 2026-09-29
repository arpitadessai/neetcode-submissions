public class KthLargest {

    private PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
    private int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;

        foreach (int i in nums)
        {
            Add(i);
        }
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);

        if (minHeap.Count > k)
        {
            minHeap.Dequeue();
        }
        
        return minHeap.Peek();
    }
}
