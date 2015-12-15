using Microsoft.Owin.Hosting;
using Serilog;

namespace SSO.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // logging
            Log.Logger = new LoggerConfiguration()
                .WriteTo
                .LiterateConsole(outputTemplate: "{Timestamp:HH:MM} [{Level}] ({Name:l}){NewLine} {Message}{NewLine}{Exception}")
                .CreateLogger();

            // hosting identityserver
            using (WebApp.Start<Startup>("https://localhost:44333"))
            {
                System.Console.WriteLine("server running...");
                System.Console.ReadLine();
            }
        }
    }
}
