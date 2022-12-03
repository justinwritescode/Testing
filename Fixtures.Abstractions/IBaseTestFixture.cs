// 
// IBaseTestFixture.cs
// 
//   Created: 2022-11-01-04:00:12
//   Modified: 2022-11-01-04:33:54
// 
//   Author: Justin Chase <justin@justinwritescode.com>
//   
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
// 


using System.ComponentModel.Design;
using JustinWritesCode.Abstractions;

namespace JustinWritesCode.Testing.Fixtures.Abstractions;

public interface IBaseTestFixture<TFixture> : ILog
    where TFixture : IBaseTestFixture<TFixture>
{
    IServiceProvider Services { get; }
    IServiceContainer ConfigureServices(IServiceContainer services);
    ITestOutputHelper Output { get; }
}

public interface IBaseTestFixture<TFixture, TUut> : IBaseTestFixture<TFixture>, IClassFixture<TUut>, ILog
    where TFixture : IBaseTestFixture<TFixture, TUut>
    where TUut : class
{
    TUut UnitUnderTest { get; }
}
