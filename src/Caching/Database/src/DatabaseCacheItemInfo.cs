// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Microsoft.Extensions.Caching.Database
{
    /// <summary>
    /// Cache Entry Item class to facilitate ORM Database Cache implmentations.
    /// </summary>
    public class DatabaseCacheItemInfo
    {
        /// <summary>
        /// cache item identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// cache item value
        /// </summary>
        public byte[] Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTimeOffset ExpiresAtTime { get; set; }

        /// <summary>
        /// Sliding expiration relative to now in seconds.
        /// </summary>
        public TimeSpan? SlidingExpirationInSeconds { get; set; }


        /// <summary>
        /// Absolute expiration of the cache item.
        /// </summary>
        public DateTimeOffset? AbsoluteExpiration { get; set; }
    }
}
