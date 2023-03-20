using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.ComponentTests
{
    public class LoggerMock : ILogger
    {
        public List<(LogLevel logLevel, object? state)> Journal
        { get; set; } = new List<(LogLevel, object?)>();
        public IDisposable BeginScope<TState>(TState state)
        => throw new NotImplementedException();
        public bool IsEnabled(LogLevel logLevel)
        => true;
        public void Log<TState>(LogLevel logLevel, EventId eventId,
        TState state, Exception? exception,
        Func<TState, Exception?, string> formatter)
        {
            Journal.Add((logLevel, state));
        }
    }
}
