public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        //check if the value already exists
        if (value == Data)
        {
            //value is already in the tree, don't do nothing
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // Check if the current node's data is equal to the value
        if (value == Data)
        {
            return true;
        }

        // If the value is less than the current node's data, search in the left subtree
        if (value < Data)
        {
            if (Left is null)
            {
                return false;  // If left is null, the value doesn't exist in this subtree
            }
            return Left.Contains(value);  // Recurse into the left child
        }

        // If the value is greater than the current node's data, search in the right subtree
        if (value > Data)
        {
            if (Right is null)
            {
                return false;  // If right is null, the value doesn't exist in this subtree
            }
            return Right.Contains(value);  // Recurse into the right child
        }
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        //return 0; // Replace this line with the correct return statement(s)

        // Base case: if the node is null, the height is 0
        if (this == null) {
            return 0;
        }
        
        // Recursively find the height of the left and right subtrees
        int leftHeight = (this.Left != null) ? this.Left.GetHeight() : 0;
        int rightHeight = (this.Right != null) ? this.Right.GetHeight() : 0;
        
        // The height of the current node is 1 + the maximum of the heights of its subtrees
        return 1 + Math.Max(leftHeight, rightHeight);

    }
}