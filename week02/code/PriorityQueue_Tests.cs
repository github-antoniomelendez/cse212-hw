using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: This test checks if basic functionality works, we check if a single item is enqueue and dequeue
    // Expected Result: [Item 1] or []
    // Defect(s) Found: The item was not dequeued, the code was fixed.
    public void TestPriorityQueue_1()
    {
        //var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");
        
        var queue = new PriorityQueue();

        // Enqueue and Dequeue the item 
        queue.Enqueue("Item1", 1);  
        var dequeuedValue = queue.Dequeue();  

        // Assert This prints Item 1 or [] because the queue is empty
        Console.WriteLine(dequeuedValue); 
        Console.WriteLine(queue.ToString());
         
    }

    [TestMethod]
    // Scenario: We are checking for FIFO behavior, first in and first out. We add items with same priority and they must be handled correctly.
    // Expected Result: [Item 1, Item 2, Item 3]
    // Defect(s) Found: The code was not working, FIFO behavior was not taking place. The code was fixed
    public void TestPriorityQueue_2()
    {
        //var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");
        
        var queue = new PriorityQueue();

        // I enqueue the items with the same priority
        queue.Enqueue("Item1", 2);
        queue.Enqueue("Item2", 2);
        queue.Enqueue("Item3", 2);

        // This returns item 1, item 2 and item 3 using the correct FIFO first in first out order
        var dequeuedValue1 = queue.Dequeue();  
        var dequeuedValue2 = queue.Dequeue();  
        var dequeuedValue3 = queue.Dequeue();  

        // Assert This prints item 1, item 2, item 3 and [] when the queue is empty
        Console.WriteLine(dequeuedValue1); 
        Console.WriteLine(dequeuedValue2); 
        Console.WriteLine(dequeuedValue3); 
        Console.WriteLine(queue.ToString()); 
    }

    [TestMethod]
    // Scenario: This test throws an error exception
    // Expected Result: This should print the queue is empty when it is empty
    // Defect(s) Found: The error exception was not working, the code was fixed
    public void TestPriorityQueue_3()
    {
        var queue = new PriorityQueue();

        // Try catch block for printing error exception when the queue is empty
        try
        {
            queue.Dequeue();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
         
    }

    // Add more test cases as needed below.
}