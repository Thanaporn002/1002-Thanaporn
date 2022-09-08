using System;

public class Money
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Please input money:");
      double input = double.Parse(Console.ReadLine());
     money(input);
    }

     public static double[] money(double input) 
     {
      double B,i,ii,iii,iv,v,vi,vii,viii,ix,x,xi;
      i = input/1000;
      B = input%1000;

      ii = B/500;
      B = B%500;

      iii = B/100;
      B = B%100;

      iv = B/50;
      B = B%50;

      v = B/20;
      B = B%20;

      vi = B/10;
      B = B%10;

      vii = B/5;
      B = B%5;

      viii = B/2;
      B = B%2;

      ix = B/1;
      B = B%1;

      x = B/.50;
      B = B%.50;

      xi = B/.25;
      B = B%.25;

      Console.WriteLine("**");
      Console.WriteLine("1000: {0}", Math.Floor(i));
      Console.WriteLine("500: {0}", Math.Floor(ii));
      Console.WriteLine("100: {0}", Math.Floor(iii));
      Console.WriteLine("50: {0}", Math.Floor(iv));
      Console.WriteLine("20: {0}", Math.Floor(v));
      Console.WriteLine("10: {0}", Math.Floor(vi));
      Console.WriteLine("5: {0}", Math.Floor(vii));
      Console.WriteLine("2: {0}", Math.Floor(viii));
      Console.WriteLine("1: {0}", Math.Floor(ix));
      Console.WriteLine(".50: {0}", Math.Floor(x));
      Console.WriteLine(".25: {0}", Math.Floor(xi));
      double[] output={Math.Floor(i),Math.Floor(ii),Math.Floor(iii),Math.Floor(iv),Math.Floor(v),Math.Floor(vi),Math.Floor(vii),Math.Floor(viii),Math.Floor(ix),Math.Floor(x),Math.Floor(xi)};
      return output;

    }
  }
