using System;
using System.Linq;
using Packt.Shared;
using static System.Console;

namespace MonitoringApp
{
  class Program
  {
    static void Main(string[] args)
    {
      
      int[] numbers = Enumerable.Range(1, 50_000).ToArray();

      WriteLine("Using string with +");
      Recorder.Start();
      string s = "";
      for (int i = 0; i < numbers.Length; i++)
      {
        s += numbers[i] + ", ";
      }
      Recorder.Stop();

      WriteLine("Using StringBuilder");
      Recorder.Start();
      var builder = new System.Text.StringBuilder();
      for (int i = 0; i < numbers.Length; i++)
      {
        builder.Append(numbers[i]); builder.Append(", ");
      }
      Recorder.Stop();
    }
  }
}