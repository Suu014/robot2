using System;
using System.Diagnostics;
using System.Threading;

namespace robot
{
    class Program
    {
        static void Main(string[] args)
        {
            var ps = new ProcessStartInfo("http://google.com")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
    }
}
