using Newtonsoft.Json;
using System.Text;

namespace JsonToNetscape
{
    public static class CookieConv
    {
        public static string ToNetscape(string json)
        {
            var objs = JsonConvert.DeserializeObject<CookieObj[]>(json);
            var sb = new StringBuilder();
            foreach (var obj in objs)
                sb.AppendLine(obj.ToString());
            return sb.ToString();
        }
    }
}
