namespace Operands.Tests;

public class Tests
{
    BlockCorrdinate starting;
    [SetUp]
    public void Setup()
    {
        starting = new BlockCorrdinate(4, 3);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void OffsetTest()
    {
        Assert.That(starting + new BlockOffset(2, 0), Is.EqualTo(new BlockCorrdinate(6,3)));
    }

    [Test]
    public void DirectionTest()
    {
        Assert.That(starting + Direction.East, Is.EqualTo(new BlockCorrdinate(4,4)));
    }
}
