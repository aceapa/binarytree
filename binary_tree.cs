using System;
using System.Text;
class BinaryTree
{
  public class Node
  {
    public int Value;
    public Node Left;
    public Node Right;
    public Node(int value)
    {
      this.Value = value;
      this.Left = null;
      this.Right = null;
    }
  }
  public Node Root;
  private StringBuilder st;
  public BinaryTree(int root)
  {
    this.Root = new Node(root);
    st = new StringBuilder();
  }
  public BinaryTree()
  {
    this.Root = null;
    st = new StringBuilder();
  }
  public void Insert(int value)
  {
    Node newNode = new Node(value);
    if (Root == null)
    {
      Root = newNode;
    }
    else
    {
      Node current = Root;
      Node parent;
      while(true)
      {
        parent = current;
        if (value < parent.Value)
        {
          current = current.Left;
          if (current == null)
          {
            parent.Left = newNode;
            return;
          }
        }
        else
        {
          current = current.Right;
          if (current == null)
          {
            parent.Right = newNode;
            return;
          }
        }
      }
    }
  }
  public void PrintBT(Node Root)
  {
    if (Root != null)
    {
        PrintBT(Root.Left);
        System.Console.Write("[{0}]" ,Root.Value);
        PrintBT(Root.Right);
    }
  }
  private void AddtoSB(int Value)
  {
    st.Append(String.Format("{0}", Value));
  }
  public string Serialize(Node Root)
  {
    if (Root != null)
    {
        AddtoSB(Root.Value);
        if (Root.Left != null)
        {
          st.Append(".");
          Serialize(Root.Left);
        }
        if (Root.Right != null)
        {
          st.Append(".");
          Serialize(Root.Right);
        }
    }
  return st.ToString();
  }
  public Node Deserialize(string StringBT)
  {
    Node node;
    node = new Node(0);
    /*string[] StringData = StringBT.Split('.');
    foreach(string StringItem in StringData)
    {
      Insert(Int32.Parse(StringItem));
    }*/
    return node;
  }

}
