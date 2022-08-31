using Serilog;

namespace Serilog_Library
{
    abstract public class LoggerBase
    {
        abstract protected LoggerConfiguration Get_LoggerConfiguration(LoggerConfiguration configuration);
        public LoggerBase()
        {
            var configuration = new LoggerConfiguration();
            configuration = Get_LoggerConfiguration(configuration);
            Log.Logger = configuration.CreateLogger();
        }

        public void Verbose(string messageTemplate) => Log.Verbose(messageTemplate);
        public void Debug(string messageTemplate) => Log.Debug(messageTemplate);
        public void Information(string messageTemplate) => Log.Information(messageTemplate);
        public void Warning(string messageTemplate) => Log.Warning(messageTemplate);
        public void Error(string messageTemplate) => Log.Error(messageTemplate);
        public void Fatal(string messageTemplate) => Log.Fatal(messageTemplate);

        public void CloseAndFlush() => Log.CloseAndFlush();
    }
}