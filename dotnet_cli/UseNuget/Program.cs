using System;
using Newtonsoft.Json;

namespace UseNuget
{
    class Program
    {
        static void Main(string[] args)
{
    dynamic account = new 
    {
        Name = "John Doe",
        Email = "john@nuget.org",
        DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
    };

    string json = JsonConvert.SerializeObject(account, Formatting.Indented);
    Console.WriteLine(json);
}
    }
}
