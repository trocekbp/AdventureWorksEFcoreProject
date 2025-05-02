using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    public static class Logger
    {
        private static readonly string logFilePath = @"..\..\..\..\log_operations.txt"; // @"..\..\..\" → przechodzi trzy poziomy wyżej, do katalogu projektu

        public static void LogOperation(string message)
        {
            File.AppendAllText(logFilePath, $"[{DateTime.Now}] {message}{Environment.NewLine}");
        }
    }
}
