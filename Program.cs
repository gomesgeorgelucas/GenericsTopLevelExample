Console.WriteLine(new Comparator().Compare(2.3D, 2.3D));

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
}

