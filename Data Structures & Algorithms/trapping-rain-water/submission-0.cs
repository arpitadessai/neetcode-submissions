public class Solution {
    public int Trap(int[] height) {
        int[] maxLeft = new int[height.Length];
        int[] maxRight = new int[height.Length];

        for (int i = 0; i < height.Length; i++)
        {
            if (i == 0)
            {
                maxLeft[i] = 0;
            }
            else 
            {
                maxLeft[i] = Math.Max(maxLeft[i-1], height[i-1]);
            }
        }

        for (int i = height.Length - 1; i > -1; i--)
        {
            if (i == height.Length - 1)
            {
                maxRight[i] = 0;
            }
            else 
            {
                maxRight[i] = Math.Max(maxRight[i+1], height[i+1]);
            }
        }

        int trappedQuantity = 0;
        for (int i = 0; i < height.Length; i++)
        {
            int temp = Math.Min(maxLeft[i], maxRight[i]) - height[i];

            if (temp > -1)
            {
                trappedQuantity = trappedQuantity + temp;
            }

        }

        return trappedQuantity;
    }
}
