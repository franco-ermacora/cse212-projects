using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("High", 5);
        pq.Enqueue("Medium", 3);

        string result = pq.Dequeue();
        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("FirstHigh", 10);
        pq.Enqueue("SecondHigh", 10);
        pq.Enqueue("Low", 1);

        string result = pq.Dequeue();
        Assert.AreEqual("FirstHigh", result);

        result = pq.Dequeue();
        Assert.AreEqual("SecondHigh", result);
    }

    // Add more test cases as needed below.
}