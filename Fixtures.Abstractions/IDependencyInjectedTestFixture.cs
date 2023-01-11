// 
// IDependencyInjectedTestFixture.cs
// 
//   Created: 2022-11-01-04:00:12
//   Modified: 2022-11-01-04:34:10
// 
//   Author: Justin Chase <justin@justinwritescode.com>
//   
//   Copyright © 2022-2023 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
// 

using System;
namespace JustinWritesCode.Testing.Fixtures.Abstractions;

public interface IDependencyInjectedTestFixture<T> : IClassFixture<T> where T : class
{
}
