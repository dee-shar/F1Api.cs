# F1Api.cs
Web-API for [f1api.dev](https://f1api.dev) a free and open source API that provides data about all Formula 1 Seasons.

## Example
```cs
using Formula1Api;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new F1Api();
            string drivers = await api.GetDrivers();
            Console.WriteLine(drivers);
        }
    }
}
```
