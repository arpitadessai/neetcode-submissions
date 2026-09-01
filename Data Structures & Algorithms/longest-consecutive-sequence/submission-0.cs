public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> unique = new HashSet<int>(nums);

        int largest = 0;

        foreach (var item in unique)
        {
            
            if (!unique.Contains(item - 1))
            {
                int currentNum = item;
                int count = 0;

                while (unique.Contains(currentNum))
                {
                    count++;
                    currentNum = currentNum + 1;
                }

                largest = Math.Max(count, largest);
            }
            
        }

        return largest;
    }
}
