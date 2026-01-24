using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: add items with same priority and dequeue them
    // Expected Result: returns items in fifo order
    // Defect(s) Found: 0
    public void TestPriorityQueue_SamePriorityFIFO()
{
    var pq = new PriorityQueue();
    pq.Enqueue("X", 4);
    pq.Enqueue("Y", 4);
    pq.Enqueue("Z", 4);

    Assert.AreEqual("X", pq.Dequeue()); 
    Assert.AreEqual("Y", pq.Dequeue()); 
    Assert.AreEqual("Z", pq.Dequeue()); 

    try
    {
        pq.Dequeue();
        Assert.Fail("Exception should have been thrown");
    }
    catch (InvalidOperationException e)
    {
        Assert.AreEqual("The queue is empty.", e.Message);
    }
}

    [TestMethod]
    // Scenario: try to dequeue from empty queue
    // Expected Result: throws exception wwith correct message
    // Defect(s) Found: 0
    public void TestPriorityQueue_EmptyQueueException()
{
    var pq = new PriorityQueue();

    try
    {
        pq.Dequeue();
        Assert.Fail("Exception should have been thrown");
    }
    catch (InvalidOperationException e)
    {
        Assert.AreEqual("The queue is empty.", e.Message);
    }
    catch (Exception e)
    {
        Assert.Fail($"Unexpected exception type {e.GetType()}: {e.Message}");
    }
}

    // Add more test cases as needed below.
}