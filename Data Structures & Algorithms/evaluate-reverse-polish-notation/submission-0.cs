public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        int i = 0;
        while (i < tokens.Length)
        {
            if (int.TryParse(tokens[i], out int number))
            {
                stack.Push(number);
            }
            else
            {
                int operandRight = stack.Pop();
                int operandLeft = stack.Pop();

                if (tokens[i] == "+")
                {
                    stack.Push(operandLeft + operandRight);
                }
                else if (tokens[i] == "-")
                {
                    stack.Push(operandLeft - operandRight);
                }
                else if (tokens[i] == "*")
                {
                    stack.Push(operandLeft * operandRight);
                }
                else
                {
                    stack.Push(operandLeft / operandRight);
                }
            }

            i++;
        }

        return stack.Pop();

    }
}
