// 
// BaseTestFixture.cs
// 
//   Created: 2022-11-01-04:00:12
//   Modified: 2022-11-01-04:33:25
// 
//   Author: Justin Chase <justin@justinwritescode.com>
//   
//   Copyright © 2022-2023 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
// 

using System.ComponentModel.Design;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using JustinWritesCode.Testing.Fixtures.Abstractions;

namespace JustinWritesCode.Testing.Fixtures;

public abstract class BaseTestFixture<TFixture> : IBaseTestFixture<TFixture>
    where TFixture : BaseTestFixture<TFixture>
{
    public virtual IServiceProvider Services { get; }
    public virtual ITestOutputHelper Output { get; }

    public ILogger Logger => Services.GetService<ILogger<TFixture>>();

    public BaseTestFixture(ITestOutputHelper output) => Output = output;

    public IServiceContainer ConfigureServices(IServiceContainer services)
    {
        throw new NotImplementedException();
    }
}

public abstract class BaseTestFixture<TFixture, TUut> : BaseTestFixture<TFixture>, IBaseTestFixture<TFixture, TUut>
    where TFixture : BaseTestFixture<TFixture, TUut>
    where TUut : class
{
    public virtual TUut UnitUnderTest { get; }

    public BaseTestFixture(ITestOutputHelper output, TUut underTest) : base(output)
    {
        UnitUnderTest = underTest;
    }
}
