using NUnit.Framework;
namespace TestDateFormat;

public class Tests
{
    [Test]
    public void DateEmpty()
    {
        const string date = "25/12/1955";
        string algo = DateFormatter.ChangeFormat(date);
        Assert.IsNotNull(algo);
    }

     [Test]
    public void TestCorrecto1()
    {
        string fecha = "10/11/1977";
        string resultado = DateFormatter.ChangeFormat(fecha);
        Assert.AreEqual("1977-11-10",resultado);
    }
    [Test]
    public void TestCorrecto2()
    {
        string fecha = "10//11//1977";
        string resultado = DateFormatter.ChangeFormat(fecha);
        Assert.AreNotEqual("1977-11-10",resultado);
    }
    [Test]
    public void Testsinguiones()
    {
        string fecha = "10/11/1977";
        string resultado = DateFormatter.ChangeFormat(fecha);
        Assert.AreNotEqual("19771110",resultado);
    }

    [Test]
    public void TestCorrecto4()
    {
        string fecha = "10//11//1977";
        string resultado = DateFormatter.ChangeFormat(fecha);
        Assert.AreNotEqual("10-11-1977",resultado);
    }

    [Test]
    public void Testsinguiones1()
    {
        string fecha = "10/11/1977";
        string resultado = DateFormatter.ChangeFormat(fecha);
        Assert.AreNotEqual("10111977",resultado);
    }
    
}