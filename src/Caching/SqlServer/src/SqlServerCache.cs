// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Database;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Internal;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.Caching.SqlServer
{
    /// <summary>
    /// Distributed cache implementation using Microsoft SQL Server database.
    /// </summary>
    public class SqlServerCache : DatabaseCache
    {
        /// <summary>
        /// Initializes a new instance of <see cref="SqlServerCache"/>.
        /// </summary>
        /// <param name="databaseOperations">The database operations for SQL Server</param>
        /// <param name="options">The configuration options.</param>
        public SqlServerCache(ICacheDatabaseOperations databaseOperations, IOptions<SqlServerCacheOptions> options) : base(databaseOperations, options)
        {

        }
    }
}
