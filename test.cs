using System;
using System.Text;
using System.Diagnostics;
class App
{
  /// <summary>
  ///   The main entry point for the application
  /// </summary>
  ///[STAThread]
  public static void Main(string[] args)
  {
    System.Console.WriteLine("start");
    BinaryTree BT = new BinaryTree();
    String SerializedBT;
    int[] intArray = new int[8]{11, 22, 13, 4, 25, 5, 3, 10};
    for(int i = 0; i < intArray.Length; i++)
    {
      BT.Insert(intArray[i]);
    }
    BT.PrintBT(BT.Root);
    //Debug.Assert()
    SerializedBT = BT.Serialize(BT.Root);
    Debug.Assert(SerializedBT == "xx.xx", "Test 1 Failed!");
    System.Console.WriteLine("\n" + SerializedBT);
    System.Console.WriteLine("\nend");
  }
}
