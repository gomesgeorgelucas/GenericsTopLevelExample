Console.WriteLine(new Comparator().Compare(2.3D, 2.3D));
Console.WriteLine(new Comparator().Compare(2.1D, 2.2D));

Console.WriteLine(new Comparator().Compare(0.1M, 0.1M));
Console.WriteLine(new Comparator().Compare(0.1M, 0.2M));

Console.WriteLine(new Comparator().Compare("", ""));
Console.WriteLine(new Comparator().Compare("", "2"));

Console.WriteLine(new Comparator().Compare(false, false));
Console.WriteLine(new Comparator().Compare(false, true));

Console.WriteLine(new Comparator().Compare(1, 1));
Console.WriteLine(new Comparator().Compare(1, 2));

class Comparator
{
    public bool Compare(string objA, string objB)
    {
        return objA.Equals(objB);
    }

    public bool Compare(int intA, int intB)
    {
        return intA == intB;
    }

    public bool Compare(double doubleA, double doubleB)
    {
        return doubleA == doubleB;
    }

    public bool Compare<T>(T genericA, T genericB) where T : IComparable<T>, IEquatable<T>
    {
        return genericA.Equals(genericB);
    }
}

