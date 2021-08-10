// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;

namespace Microsoft.Extensions.Caching.Database
{
    /// <summary>
    /// Interface for operations in the <see cref="DatabaseCache"/>.
    /// </summary>
    public interface ICacheDatabaseOperations
    {
        /// <summary>
        /// Retrieve the Cache Item from the database
        /// </summary>
        /// <param name="key">The key of the cache item.</param>
        byte[] GetCacheItem(string key);

        /// <summary>
        /// Retrieve the Cache Item async from the database
        /// </summary>
        /// <param name="key">The key of the cache item.</param>
        /// <param name="token">The cancellation token for the retrieval</param>
        Task<byte[]> GetCacheItemAsync(string key, CancellationToken token = default(CancellationToken));

        /// <summary>
        /// Update the cache item in the database
        /// </summary>
        /// <param name="key">The key of the cache item.</param>
        void RefreshCacheItem(string key);

        /// <summary>
        /// Update the cache item in the database
        /// </summary>
        /// <param name="key">The key of the cache item.</param>
        /// <param name="token">The cancellation token for the update</param>
        Task RefreshCacheItemAsync(string key, CancellationToken token = default(CancellationToken));

        /// <summary>
        /// Delete the cache item in the database
        /// </summary>
        /// <param name="key">The key of the cache item.</param>
        void DeleteCacheItem(string key);

        /// <summary>
        /// Delete the cache item in the database
        /// </summary>
        /// <param name="key">The key of the cache item.</param>
        /// <param name="token">The cancellation token for the deletion</param>
        Task DeleteCacheItemAsync(string key, CancellationToken token = default(CancellationToken));

        /// <summary>
        /// Insert cache item in the database
        /// </summary>
        /// <param name="key">The key of the cache item.</param>
        /// <param name="value">The cache value</param>
        /// <param name="options">The cache item entry options</param>
        void SetCacheItem(string key, byte[] value, DistributedCacheEntryOptions options);

        /// <summary>
        /// Insert cache item in the database
        /// </summary>
        /// <param name="key">The key of the cache item.</param>
        /// <param name="value">The cache value</param>
        /// <param name="options">The cache item entry options</param>
        /// <param name="token">The cancellation token for the insertion</param>
        Task SetCacheItemAsync(string key, byte[] value, DistributedCacheEntryOptions options, CancellationToken token = default(CancellationToken));

        /// <summary>
        /// Remove expired cache items from the database
        /// </summary>
        void DeleteExpiredCacheItems();
    }
}
