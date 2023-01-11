// 
// OutputHelperLoggerProvider.cs
// 
//   Created: 2022-11-01-04:00:12
//   Modified: 2022-11-01-04:34:59
// 
//   Author: Justin Chase <justin@justinwritescode.com>
//   
//   Copyright © 2022-2023 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
// 

//
//  OutputHelperLoggerFactory.cs
//
//  Author:
//       David G. Moore, Jr. <david@dgmjr.io>
//
//  Copyright (c) 2022 2022 David G. Moore, Jr.
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using Microsoft.Extensions.Logging;
namespace JustinWritesCode.Testing.Logging;

public class OutputHelperLoggerProvider : ILoggerProvider
{
    private ITestOutputHelper _output;
    public OutputHelperLoggerProvider(ITestOutputHelper outputHelper)
    {
        _output = outputHelper;
    }

    public ILogger CreateLogger(string categoryName)
        => new OutputHelperLogger(_output);

    public void Dispose() { }
}
