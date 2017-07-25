using System;

namespace IpChallenge
{
    internal static class Program
    {
        private static void Main()
        {
            var ipDetails = new IpDetails();

            Console.Write("Please Enter an IP Address: ");
            var ipAddress = Console.ReadLine() ?? "";

            ipDetails.AnalyzeIpAddress(ipAddress);

            Console.Write("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}