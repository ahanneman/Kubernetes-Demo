using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleSpammer
{
    class Program
    {
        static void Main(string[] args)
        {
           Run();
            Console.ReadLine();
        }

        static void Run()
        {
            Parallel.Invoke(GetMachineName, 
                GetMachineName, 
                GetMachineName, 
                GetMachineName, 
                GetMachineName, 
                GetMachineName, 
                GetMachineName, 
                GetMachineName, 
                GetMachineName, 
                GetMachineName,
                GetMachineName,
                GetMachineName);
        }

        static async void GetMachineName()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://104.43.138.208/api/MachineName");
            var machineName = await response.Content.ReadAsStringAsync();
            Console.WriteLine(machineName);
        }
    }
}
