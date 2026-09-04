public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        HashSet<char> openingBraces = new HashSet<char>();
        openingBraces.Add('(');
        openingBraces.Add('[');
        openingBraces.Add('{');

        Stack<char> stack = new Stack<char>();
        foreach (var c in s)
        {
            if (openingBraces.Contains(c))
            {
                stack.Push(c);
                continue;
            }

            if (stack.Count <= 0) return false;

            char popped = stack.Pop();

            switch (c){
                case ')':
                    if (popped != '(') return false;
                    break;
                case ']':
                    if (popped != '[') return false;
                    break;
                case '}':
                    if (popped != '{') return false;
                    break;
                default:
                    return false;
            }

        }

        return stack.Count == 0;

    }
}
