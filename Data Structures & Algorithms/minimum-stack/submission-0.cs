public class MinStack {

    private Stack<(int Value, int Min)> stack;

    public MinStack() {
        stack = new();
    }
    
    public void Push(int val) {
        int currentMin = int.MaxValue;
        if (stack.Count > 0)
        {
            currentMin = stack.Peek().Min;
        }
        
        stack.Push((val, Math.Min(currentMin, val)));
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().Value;
    }
    
    public int GetMin() {
        return stack.Peek().Min;
    }
}
