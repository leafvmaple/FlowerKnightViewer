using Fiddler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlowerWrapper
{
    public static class FlowerProxyExtensions
    {
        /// <summary>
		/// FiddlerCore 数据解析
		/// </summary>
		public static IObservable<T> TryParse<T>(this IObservable<Session> source) where T : class
        {
            Func<Session, T> converter = session =>
            {
                T result;
                return TryParse<T>(session, out result) ? result : null;
            };

            return source.Select(converter).Where(x => x != null);
        }

        public static bool TryParse<T>(Session session, out T result) where T : class
        {
            try
            {
                result = Parse<T>(session);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                result = null;
                return false;
            }

            return true;
        }
        public static T Parse<T>(Session session) where T : class
        {
            var bytes = Encoding.UTF8.GetBytes(session.GetResponseBodyAsString());
            Debug.WriteLine(bytes);
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var stream = new MemoryStream(bytes))
            {
                var result = serializer.ReadObject(stream) as T;
                return result;
            }
        }
    }
}
