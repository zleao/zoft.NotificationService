using System;

namespace zoft.NotificationService
{
    internal static class LogProvider
    {
        internal static void Trace(string message) => Console.WriteLine(message);
        internal static void Warn(string message) => Console.WriteLine(message);
    }
}