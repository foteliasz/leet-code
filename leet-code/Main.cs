namespace leet_code;

public class AClass
{
    public string Value { get; set; }
}

public struct AStruct
{
    public string Value { get; set; }
}

public class LeetCode
{
    public static void Main()
    {
        Console.WriteLine($"1 hash code: {1.GetHashCode()}");
        Console.WriteLine($"2 hash code: {2.GetHashCode()}");

        var strA = "one";
        var strB = "two";
        var strC = "one";
        Console.WriteLine($"'one' hash code: {strA.GetHashCode()}");
        Console.WriteLine($"'two' hash code: {strB.GetHashCode()}");
        Console.WriteLine($"'one' hash code: {strC.GetHashCode()}");

        var clsA = new AClass { Value = "one" };
        var clsB = new AClass { Value = "two" };
        var clsC = new AClass { Value = "one" };
        Console.WriteLine($"clsA hash code: {clsA.GetHashCode()}");
        Console.WriteLine($"clsB hash code: {clsB.GetHashCode()}");
        Console.WriteLine($"clsC hash code: {clsC.GetHashCode()}");
        
        var structA = new AStruct { Value = "one" };
        var structB = new AStruct { Value = "two" };
        var structC = new AStruct() { Value = "one" };
        Console.WriteLine($"structA hash code: {structA.GetHashCode()}");
        Console.WriteLine($"structB hash code: {structB.GetHashCode()}");
        Console.WriteLine($"structC hash code: {structC.GetHashCode()}");
        
        
        Console.ReadKey();
    }
}