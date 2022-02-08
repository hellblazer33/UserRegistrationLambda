using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexPattern;
namespace JUnitTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    { 
        string result = PatternCheck.PatternCheck1();
        Assert.AreEqual("Happy", result);
    }
}
