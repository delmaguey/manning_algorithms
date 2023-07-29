
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
        string result = string.Format("{0}:", Value);

        if(LeftChild==null)
            result += " null";
        else
            result += string.Format(" {0}", LeftChild.Value);

        if(RightChild==null)
            result += " null";
        else
            result += string.Format(" {0}", RightChild.Value);

        return result;
    }

}