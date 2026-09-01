public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder result = new StringBuilder();

        foreach (var s in strs)
        {
            result.Append(s.Length);
            result.Append("#");
            result.Append(s);
        }

        return result.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();

        int i = 0;
        while (i < s.Length)
        {
            StringBuilder sb = new StringBuilder();
            
            while (s[i] != '#')
            {
                sb.Append(s[i]);
                i++;
            }

            int length = int.Parse(sb.ToString());
            i++;
            result.Add(s.Substring(i, length));

            i = i + length;
        }

        return result;
   }
}
