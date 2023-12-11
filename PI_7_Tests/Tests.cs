global using NUnit.Framework;

public class Tests
{
    [Test]
    public void Test1()
    {
        int a = 3, b = 4, c = 5;

        int a2 = (int)Math.Pow(a, 2);
        int b2 = (int)Math.Pow(b, 2);
        int c2 = (int)Math.Pow(c, 2);

        Assert.IsTrue(a2 + b2 == c2);
    }

    [Test]
    public void Test2()
    {
        int a = 1, b = 1, c = 1;

        int a2 = (int)Math.Pow(a, 2);
        int b2 = (int)Math.Pow(b, 2);
        int c2 = (int)Math.Pow(c, 2);

        Assert.IsTrue(a2 + b2 != c2);
    }

    [Test]
    public void Test3()
    {
        int a = 45, b = 28, c = 53;

        int a2 = (int)Math.Pow(a, 2);
        int b2 = (int)Math.Pow(b, 2);
        int c2 = (int)Math.Pow(c, 2);

        Assert.IsTrue(a2 + b2 == c2);
    }
}