using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {

    double[] input_cel = new double[7];
    double[] fahrenheit = new double[7];

    for(int pos = 0; pos < 7; pos++)
    {
      Console.WriteLine("Enter temperature in celsius");

      input_cel[pos]=Convert.ToDouble(Console.ReadLine());

      fahrenheit[pos]=(input_cel[pos] * 9/5) + 32;
    }

    Console.WriteLine("Temperature in Fahrenheit");
    foreach(double item in fahrenheit)
    {
      Console.WriteLine(item);
    }
    double sum = fahrenheit.Sum();
    double avg = (sum/7);
    Console.WriteLine("Average weekly temperature is " + avg + " degrees fahrenheit");
  }
}