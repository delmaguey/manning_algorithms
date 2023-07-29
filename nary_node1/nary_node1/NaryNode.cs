
public class NaryNode<T>
{
    public T Value;
    public List<NaryNode<T>> Children;


    public NaryNode(T value)
    {
        this.Value = value;
        this.Children = new List<NaryNode<T>>();
    }

    public void AddChild(NaryNode<T> child)
    {
        Children.Add(child);
    }

    public override string ToString()
    {
        string result = string.Format("{0} : ", Value);

        foreach (var item in Children)
        {
            result += string.Format(" {0}", item.Value);
        }

        return result;
    }


}