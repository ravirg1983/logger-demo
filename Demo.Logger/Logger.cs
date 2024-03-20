using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Logger
{
    public class Logger
    {
        private Dictionary<LogLevel, List<ILog>> sinks = new Dictionary<LogLevel, List<ILog>>();

        public void Configure(Dictionary<LogLevel, List<ILog>> config)
        {
            foreach (var kvp in config)
            {
                if (!sinks.ContainsKey(kvp.Key))
                    sinks[kvp.Key] = new List<ILog>();

                sinks[kvp.Key].AddRange(kvp.Value);
            }
        }

        public void Log(LogMessage message)
        {
            if (sinks.ContainsKey(message.Level))
            {
                foreach (var sink in sinks[message.Level])
                {
                    sink.Log(message);
                }
            }
            else
            {
                Console.WriteLine($"No sink configured for level: {message.Level}");
            }
        }
    }
}
