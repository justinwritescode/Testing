// 
// OutputHelperLogger.cs
// 
//   Created: 2022-11-01-04:00:12
//   Modified: 2022-11-01-04:29:49
// 
//   Author: Justin Chase <justin@justinwritescode.com>
//   
//   Copyright © 2022-2023 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
// 

using System;
using Microsoft.Extensions.Logging;
using NSubstitute;
using global::Xunit.Abstractions;

namespace JustinWritesCode.Testing.Logging;

public class OutputHelperLogger : ILogger
{
    private ITestOutputHelper _output;
    public OutputHelperLogger(ITestOutputHelper outputHelper)
    {
        _output = outputHelper;
    }

    public IDisposable BeginScope<TState>(TState state)
    {
        return Substitute.For<IDisposable>();
    }

    public bool IsEnabled(LogLevel logLevel) => true;

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        _output.WriteLine(formatter(state, exception));
    }
}
