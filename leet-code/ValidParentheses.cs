public partial class Solution {
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            switch (c)
            {
                case '(' or '[' or '{':
                    stack.Push(c);
                    break;
                case ')':
                    if (stack.Count == 0) return false;
                    var c2 = stack.Pop();
                    if (c2 != '(') return false;
                    break;
                case ']':
                    if (stack.Count == 0) return false;
                    c2 = stack.Pop();
                    if (c2 != '[') return false;
                    break;
                case '}':
                    if (stack.Count == 0) return false;
                    c2 = stack.Pop();
                    if (c2 != '{') return false;
                    break;
            }
        }

        return stack.Count == 0;
    }
}