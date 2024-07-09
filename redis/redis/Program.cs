using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace ReferenceConsoleRedisApp
{
    class Program
    {
        static ConnectionMultiplexer redis;
        static void Main(string[] args)
        {
            // Redis serveriga ulanish
            redis = ConnectionMultiplexer.Connect("redis-10706.c81.us-east-1-2.ec2.redns.redis-cloud.com:10706,password=6I96EnV2ODwF97KqX6GAvjm9pfBlfcAe"); // Redis server manzili

            // Ma'lumotlarni o'qish
            ReadStringData();
            ReadHashData();
            ReadListData();
            ReadSetData();
            ReadSortedSetData();
        }

        static void ReadStringData()
        {
            IDatabase db = redis.GetDatabase();

            // Redisdan string ma'lumotni o'qish
            string value = db.StringGet("mystringkey");
            Console.WriteLine("String Value: " + value);
        }

        static void ReadHashData()
        {
            IDatabase db = redis.GetDatabase();

            // Redisdan hash ma'lumotni o'qish
            HashEntry[] hashEntries = db.HashGetAll("myhashkey");
            foreach (var entry in hashEntries)
            {
                Console.WriteLine($"{entry.Name}: {entry.Value}");
            }
        }

        static void ReadListData()
        {
            IDatabase db = redis.GetDatabase();

            // Redisdan list ma'lumotni o'qish
            RedisValue[] listItems = db.ListRange("mylistkey");
            Console.WriteLine("List Items:");
            foreach (var item in listItems)
            {
                Console.WriteLine(item);
            }
        }

        static void ReadSetData()
        {
            IDatabase db = redis.GetDatabase();

            // Redisdan set ma'lumotni o'qish
            RedisValue[] setItems = db.SetMembers("mysetkey");
            Console.WriteLine("Set Items:");
            foreach (var item in setItems)
            {
                Console.WriteLine(item);
            }
        }

        static void ReadSortedSetData()
        {
            IDatabase db = redis.GetDatabase();

            // Redisdan sorted set ma'lumotni o'qish
            SortedSetEntry[] sortedSetItems = db.SortedSetRangeByRankWithScores("mysortedsetkey");
            Console.WriteLine("Sorted Set Items:");
            foreach (var item in sortedSetItems)
            {
                Console.WriteLine($"{item.Element}: {item.Score}");
            }
        }

        /*private static ConnectionMultiplexer redis;

        static void Main(string[] args)
        {
            // Connect to the Redis server
            redis = ConnectionMultiplexer.Connect("redis-10706.c81.us-east-1-2.ec2.redns.redis-cloud.com:10706,password=6I96EnV2ODwF97KqX6GAvjm9pfBlfcAe"); // Change "localhost" to your Redis server address

            // Add data
            AddStringData();
            AddHashData();
            AddListData();
            AddSetData();
            AddSortedSetData();
        }

        static void AddStringData()
        {
            IDatabase db = redis.GetDatabase();

            // Add string data
            db.StringSet("mystringkey", "mystringvalue");
            Console.WriteLine("String data added.");
        }

        static void AddHashData()
        {
            IDatabase db = redis.GetDatabase();

            // Add hash data
            db.HashSet("myhashkey", new HashEntry[]
            {
            new HashEntry("field1", "value1"),
            new HashEntry("field2", "value2"),
            new HashEntry("field3", "value3")
            });
            Console.WriteLine("Hash data added.");
        }

        static void AddListData()
        {
            IDatabase db = redis.GetDatabase();

            // Add list data
            db.ListRightPush("mylistkey", "item1");
            db.ListRightPush("mylistkey", "item2");
            db.ListRightPush("mylistkey", "item3");
            Console.WriteLine("List data added.");
        }

        static void AddSetData()
        {
            IDatabase db = redis.GetDatabase();

            // Add set data
            db.SetAdd("mysetkey", "member1");
            db.SetAdd("mysetkey", "member2");
            db.SetAdd("mysetkey", "member3");
            Console.WriteLine("Set data added.");
        }

        static void AddSortedSetData()
        {
            IDatabase db = redis.GetDatabase();

            // Add sorted set data
            db.SortedSetAdd("mysortedsetkey", "member1", 1.0);
            db.SortedSetAdd("mysortedsetkey", "member2", 2.0);
            db.SortedSetAdd("mysortedsetkey", "member3", 3.0);
            Console.WriteLine("Sorted set data added.");
        }*/
    }
}