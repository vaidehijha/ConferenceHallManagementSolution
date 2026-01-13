using System.Runtime.Caching;

namespace ProjectUtility
{
    public interface ICacheStorage
    {
        void Remove(string key);
        void Store(string key, object data);
        T Retrieve<T>(string key);
    }
    public class ObjectCacheAdapter  : ICacheStorage
    {
        ObjectCache _c = MemoryCache.Default;
        static DateTime date = DateTime.Now.AddDays(1);
        static readonly CacheItemPolicy Policy = new CacheItemPolicy() { AbsoluteExpiration = new DateTimeOffset(new DateTime(date.Year, date.Month, date.Day, 5, 0, 0)) };
        public void Remove(string key)
        {
            _c.Remove(key);
        }

        public void Store(string key, object data)
        {
            _c.Add(key, data, Policy);
        }

        public T Retrieve<T>(string key)
        {
            T itemStored = (T)_c.Get(key);
            if (itemStored == null)
            {
                itemStored = default(T);
            }
            return itemStored;
        }
    }
}
