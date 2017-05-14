using Nekoxy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using zlib;

namespace FlowerWrapper
{
    public static class FlowerProxyExtensions
    {
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
            var byJson = (session.Request.PathAndQuery.IndexOf("/api/v1/") != -1) ? DecryptData(session.Response.Body) : session.Response.Body;
            Debug.WriteLine(byJson);
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var stream = new MemoryStream(byJson))
            {
                var result = serializer.ReadObject(stream) as T;
                return result;
            }
        }

        public static byte[] DecryptData(byte[] bytes)
        {
            var stream  = new MemoryStream();
            var zStream = new ZOutputStream(stream);
            zStream.Write(bytes, 0, bytes.Length);
            zStream.Flush();

            bytes = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(bytes, 0, bytes.Length);
            stream.Close();
            zStream.finish();
            zStream.Close();

            return Convert.FromBase64String(Encoding.UTF8.GetString(bytes));
        }
    }
}
