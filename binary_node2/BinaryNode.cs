
public class BinaryNode<T>
{
    public T Value {get; set;}
    public BinaryNode<T>? LeftChild;
    public BinaryNode<T>? RightChild;

    public BinaryNode(T value)
    {
        this.Value = value;
        this.LeftChild = null;
        this.RightChild = null;
    }

    public void AddLeft(BinaryNode<T> left)
    {
        this.LeftChild = left;
    }
    public void AddRight(BinaryNode<T> right)
    {
        this.RightChild = right;
    }

    public override string ToString()
    {
        return ToString("");
    }

    public string ToString(string spaces)
    {
        string result = string.Format("{0}{1}:\n", spaces, Value);

        if (LeftChild != null || RightChild != null)
        {
            //****** Left Child
            if(LeftChild == null)
                result += string.Format("{0}{1}null\n", spaces, " ");
            else
                result += LeftChild.ToString(spaces + " ");

            //****** Right Child
            if(RightChild == null)
                result += string.Format("{0}{1}null\n", spaces, "  ");
            else
                result += RightChild.ToString(spaces + " ");
        }

        return result;
    }

}