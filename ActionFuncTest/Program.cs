using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActionFuncDelegate.ActionFuncDelegates; // Adjust the namespace as needed

class Program
{
    static void Main(string[] args)
    {
        RunTest();
    }

    static void RunTest()
    {
        var actionFuncTest = new ActionFuncTest();
        actionFuncTest.GivenTwoNumbers_WhenRunDelegateInvoked_ReturnCorrectResults();
    }
}

[TestClass]
public class ActionFuncTest
{
    [TestMethod]
    public void GivenTwoNumbers_WhenRunDelegateInvoked_ReturnCorrectResults()
    {
        var delegates = new ActionAndFucntionDelegate();

        var result = delegates.RunDelegate(5, 10);

        Assert.AreEqual(15, result.IncrementedNumber, "IncrementedNumber should be 15.");
        Assert.AreEqual(15, result.AddResult, "AddResult should be 15.");
    }
}
