using System;

namespace MDT
{
  public class Program 
  {
    public static store  Createstore(string Name,
    double Number,
    string OwnerName,
    double RegisteredValue) 
    {
      return new store(Name,
      Number,
      OwnerName,
      RegisteredValue);
    }
    public static void Main(string[] args) 
    {
      Console.WriteLine("Please input Name:");
      string Name = Console.ReadLine();
      Console.WriteLine("Please input Number:");
      Console.WriteLine("Please input Owner Name:");
      string OwnerName = Console.ReadLine();
      Console.WriteLine("Please input Registered Value:");
      double RegisteredValue = double.Parse(Console.ReadLine());
      store Main = Createstore(Name,Number,OwnerName,RegisteredValue);

       PrintstoreInformation(Main);
 
    }
    static void PrintstoreInformation(store Main) 
    {
      Console.WriteLine("**************************");
      Console.WriteLine("Name: {0}", Main.Name);
      Console.WriteLine("Nunber: {0}", Main.Number);
      Console.WriteLine("Owner Name: {0}", Main.OwnerName);
      Console.WriteLine("Registered Value: {0}", Main.RegisteredValue);
    }
 }
}
 


