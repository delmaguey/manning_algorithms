
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
        return ToString("");
    }

    public string ToString(string spaces)
    {
        string result = string.Format("{0}{1}: \n", spaces, Value);

        if(Children != null)
        {
            foreach (var child in Children)
            {
                if(child.Value == null)
                {
                    result = string.Format("{0}{1}\n", spaces, "  ");
                }
                else
                {
                    result += child.ToString(spaces + "  ");
                }
            }
        }

        return result;
    }


}