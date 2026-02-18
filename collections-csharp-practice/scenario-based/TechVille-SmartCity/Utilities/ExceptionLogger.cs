using System;
using System.IO;

namespace TechVilleSmartCity.Utilities
{
    public class ExceptionLogger
    {
        private static string logFilePath = "error_log.txt";

        public static void Log(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine("=====================================");
                writer.WriteLine("Date: " + DateTime.Now);
                writer.WriteLine("Exception Type: " + ex.GetType().Name);
                writer.WriteLine("Message: " + ex.Message);
                writer.WriteLine("=====================================");
            }
        }
    }
}
