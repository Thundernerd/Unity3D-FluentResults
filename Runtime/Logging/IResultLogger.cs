// ReSharper disable once CheckNamespace

using FluentResults.Microsoft.Extensions.Logging;

namespace FluentResults
{
    public interface IResultLogger
    {
        void Log(string context, string content, ResultBase result, LogLevel logLevel);
        void Log<TContext>(string content, ResultBase result, LogLevel logLevel);
    }
}