using LoggerUtilities;

namespace TestLogger
{
    public class TestLoggerProgram
    {
        static LoggerClient client;

        public static void Main(string[] args)
        {
            try
            {
                LoggerUtilities.Logger.ILogger[] loggers = new LoggerUtilities.Logger.ILogger[] { new LoggerUtilities.Logger.ConsoleLogger() };

                client = new LoggerClient("TestLoggerProgram", "127.0.0.1", 10020, loggers);
                client.SendWarning("Warning");
                client.SendError("Error");
                client.SendInfo("Info");
                client.SendPositive("Positive");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();

            client.Close();
        }
    }
}
