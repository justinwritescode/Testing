// 
// DependencyInjectedTestFixture.cs
// 
//   Created: 2022-11-01-04:00:12
//   Modified: 2022-11-01-04:32:37
// 
//   Author: Justin Chase <justin@justinwritescode.com>
//   
//   Copyright © 2022-2023 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
// 
using System;
using System.ComponentModel.Design;

namespace JustinWritesCode.Testing.Fixtures.Abstractions;

public class DependencyInjectedTestFixture<TFixture, TSut> : BaseTestFixture<TFixture, TSut>, IDependencyInjectedTestFixture<TSut>
    where TFixture : DependencyInjectedTestFixture<TFixture, TSut>, IDependencyInjectedTestFixture<TSut>
    where TSut : class
{
    public DependencyInjectedTestFixture(ITestOutputHelper output, TSut underTest) : base(output, underTest)
    {
        var container = new ServiceContainer();
        ConfigureServices(container);
    }
}
