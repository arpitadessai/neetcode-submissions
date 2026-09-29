public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        foreach (var s in stones)
        {
            heap.Enqueue(s, s);
        }

        while (heap.Count > 1)
        {
            int y = heap.Dequeue();
            int x = heap.Dequeue();

            if (x < y)
            {
                heap.Enqueue(y-x, y-x);
            }
        }

        return heap.Count == 0 ? 0 : heap.Peek();
    }
}
