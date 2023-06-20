using Newtonsoft.Json;

namespace MelodicJourneysOfCollin.Services
{
    public static class DevCode
    {
        public static string ToJson(this Object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T ToObject<T>(this string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
        
        public static string Get<T>(this IEnumerable<T> lst, T detail)
        {
            return (lst.ToList().IndexOf(detail) + 1).ToString();
        }
    }
}
