﻿using System;
using System.Runtime.CompilerServices;

namespace Carbon.Json
{
    internal static class JsonModelCache
    {
        private static readonly ConditionalWeakTable<Type, JsonModel> cache
            = new ConditionalWeakTable<Type, JsonModel>();

        public static JsonModel Get(Type type) => cache.GetValue(type, Create);

        private static JsonModel Create(Type type) => JsonModel.FromType(type);
    }
}