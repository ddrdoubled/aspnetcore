// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Microsoft.Extensions.Caching.Database;
using Microsoft.Extensions.Internal;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.Caching.SqlServer
{
    /// <summary>
    /// Configuration options for <see cref="SqlServerCache"/>.
    /// </summary>
    public class SqlServerCacheOptions : DatabaseCacheOptions, IOptions<SqlServerCacheOptions>
    {
        SqlServerCacheOptions IOptions<SqlServerCacheOptions>.Value
        {
            get
            {
                return this;
            }
        }
    }
}
