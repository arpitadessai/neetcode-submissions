public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> minHeap = new PriorityQueue<int[], double>();

        for (int i = 0; i < points.Length; i++)
        {
            double distance = Math.Sqrt((points[i][0] * points[i][0]) + (points[i][1] * points[i][1]));

            minHeap.Enqueue(points[i], -distance);

            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        int[][] result = new int[k][];

        for (int i = 0; i < k; i++)
        {
            result[i] = minHeap.Dequeue();
        }

        return result;
    }
}
