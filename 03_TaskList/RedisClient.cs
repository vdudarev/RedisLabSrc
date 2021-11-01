using System;
using StackExchange.Redis;

namespace TaskList
{
    public static class RedisClient
    {
        /// <summary>
        /// Maximum number of versions to store
        /// </summary>
        public const uint MaxCount = 5;
        
        private static ConnectionMultiplexer redis;
        private static IDatabase database;

        public static void Connect(string connectionString = "localhost")
        {
            redis = ConnectionMultiplexer.Connect(connectionString);
            database = redis.GetDatabase();
        }

        public static string Get(string key)
        {
            throw new NotImplementedException();
        }

        public static bool Exist(string key)
        {
            throw new NotImplementedException();
        }

        public static void Add(string key, string value)
        {
            throw new NotImplementedException();
        }

        public static string Back(string key)
        {
            throw new NotImplementedException();

        }
    }
}