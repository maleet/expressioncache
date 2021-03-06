﻿namespace ExpressionCache.Core.Tests.TestHelpers
{
    public class CacheObject : ICacheKey
    {
        public int Parameter1 { get; set; }
        public string Parameter2 { get; set; }

        public CacheObject(int parameter1, string parameter2)
        {
            Parameter1 = parameter1;
            Parameter2 = parameter2;
        }

        public void BuildCacheKey(ICacheKeyBuilder builder)
        {
            builder
                .By(Parameter1)
                .By(Parameter2);
        }
    }
}
