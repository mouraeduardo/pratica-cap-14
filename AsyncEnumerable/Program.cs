using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace AsyncEnumerable
{
  class Program
  {
    async static IAsyncEnumerable<int> GetNumbers()
    {

      var aleatorio = new Random();
      
      await Task.Run(() => Task.Delay(aleatorio.Next(1500, 3000)));
      yield return aleatorio.Next(0, 1001);

      await Task.Run(() => Task.Delay(aleatorio.Next(1500, 3000)));
      yield return aleatorio.Next(0, 1001);

      await Task.Run(() => Task.Delay(aleatorio.Next(1500, 3000)));
      yield return aleatorio.Next(0, 1001);
    }

    static async Task Main(string[] args)
    {
      await foreach (int number in GetNumbers())
      {
        WriteLine($"Number: {number}");
      }
    }
  }
}