namespace CalcTests;

using System;
using Calculator;

[TestFixture]
public class Tests
{
    CalcCore cal;

    [OneTimeSetUp]
    public void Setup()
    {
        cal = new CalcCore();
        Console.WriteLine("Setup----");
    }
    [OneTimeTearDown]
    public void TearDown()
    {
        Console.WriteLine("ShutDown----");
    }

    [TestCase(100,50,50)]
    [TestCase(40, 20, 20)]
    [TestCase(100, 99, 1)]
    [TestCase(10, 9, 1)]
    public void AdditionTest1(int Expected, int First, int Second)
    {
        Console.WriteLine("AdditionTest1----");
        Assert.That(Expected, Is.EqualTo(cal.Add(First,Second)));
    }
    [TestCase(10,5,2)]
    [TestCase(100, 50, 2)]
    [TestCase(20, 10, 2)]
    public void MultiplyTests(int Expected, int First, int Second)
    {
        Console.WriteLine("MultiplyTests----");
        Assert.AreEqual(Expected, cal.Multiply(First, Second));
    }

    [TestCase(5, 10, 2)]
    [TestCase(5, 50, 10)]
    [TestCase(10, 100, 10)]
    public void DivideTests(int Expected, int First, int Second)
    {
        Console.WriteLine("DivideTests----");
        Assert.AreEqual(Expected, cal.Divide(First, Second));
    }
    [Test]
    //[Ignore("Not used in QA")]
    public void DivideZeroTest()
    {
        Assert.Throws<DivideByZeroException>(delegate { cal.Divide(3, 0); });
    }
}
