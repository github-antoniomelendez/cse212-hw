public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority. 
    /// The node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode); // Always add to the back of the queue
    }

    public string Dequeue()
    {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // This finds the index of the item with the highest priority
        var highPriorityIndex = 0;
        for (int index = 1; index < _queue.Count; index++)
        {
            // This checks if the current item has a higher priority, or the same priority but is earlier (FIFO - first in, first out queue model)
            if (_queue[index].Priority > _queue[highPriorityIndex].Priority)
            {
                highPriorityIndex = index;
            }
            else if (_queue[index].Priority == _queue[highPriorityIndex].Priority)
            {
                // If the priorities are the same, keep the item that is earlier in the list (FIFO - first in, first out queue model)
                
            }
        }

        // This gets the value of the item with the highest priority
        var value = _queue[highPriorityIndex].Value;

        // This removes the item with the highest priority from the queue
        _queue.RemoveAt(highPriorityIndex);

        return value;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}