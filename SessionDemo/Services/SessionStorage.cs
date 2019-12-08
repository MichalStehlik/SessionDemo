using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SessionDemo.Helpers;

namespace SessionDemo.Services
{
    public class SessionStorage<T> where T: new()
    {
        readonly ISession _session;

        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
        }

        public T LoadOrCreate(string key)
        {
            T result = _session.Get<T>(key);
            if (result == null) result = new T();
            return result;
        }

        public void Save(string key, T data)
        {
            _session.Set(key, data);
        }
    }
}
