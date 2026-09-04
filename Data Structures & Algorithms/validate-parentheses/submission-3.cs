public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        Stack<char> stack = new Stack<char>();
        foreach (var c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) return false;

                char popped = stack.Pop();

                if (c == ']' && popped != '[') return false;
                if (c == '}' && popped != '{') return false;
                if (c == ')' && popped != '(') return false;
            }
        }

        return stack.Count == 0;

    }
}
