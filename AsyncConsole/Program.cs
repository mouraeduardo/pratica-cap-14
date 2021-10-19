using System;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Console;

namespace AsyncConsole
{
  class Program
  {
    static async Task Main(string[] args)
    {
      var httpClient = new HttpClient();

      HttpResponseMessage response =
        await httpClient.GetAsync("http://www.apple.com/");


      WriteLine("A pagina inicial da apple tem: {0:N0} bytes.",
        response.Content.Headers.ContentLength);
    }
  }
}