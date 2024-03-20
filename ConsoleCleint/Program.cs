// See https://aka.ms/new-console-template for more information
using Demo.Logger;

Console.WriteLine("Hello, World!");
var consoleSink = new ConsoleLog();
var fileSink = new FileLog("log.txt");

var logger = new Demo.Logger.Logger();
var config = new Dictionary<Demo.Logger.LogLevel, List<ILog>>
            {
                { Demo.Logger.LogLevel.FATAL, new List<ILog> { consoleSink, fileSink } },
                { Demo.Logger.LogLevel.ERROR, new List<ILog> { fileSink } },
                { Demo.Logger.LogLevel.WARN, new List<ILog> { consoleSink } },
                { Demo.Logger.LogLevel.INFO, new List<ILog> { fileSink } },
                { Demo.Logger.LogLevel.DEBUG, new List<ILog>() }
            };

logger.Configure(config);

logger.Log(new LogMessage { Content = "This is a fatal error", Level = Demo.Logger.LogLevel.FATAL, Namespace = "location1" });
logger.Log(new LogMessage { Content = "This is an error", Level = Demo.Logger.LogLevel.ERROR, Namespace = "location2" });
logger.Log(new LogMessage { Content = "This is a warning", Level = Demo.Logger.LogLevel.WARN, Namespace = "location3" });
logger.Log(new LogMessage { Content = "This is an info message", Level = Demo.Logger.LogLevel.INFO, Namespace = "location4" });
logger.Log(new LogMessage { Content = "This is a debug message", Level = Demo.Logger.LogLevel.DEBUG, Namespace = "location5" });
