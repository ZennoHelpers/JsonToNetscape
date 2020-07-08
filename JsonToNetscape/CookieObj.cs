using Newtonsoft.Json;
using System;
using System.Globalization;

namespace JsonToNetscape
{
    public class CookieObj
    {
        public string domain { get; set; }
        public double expirationDate { get; set; }
        public bool hostOnly { get; set; }
        public bool httpOnly { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string sameSite { get; set; }
        public bool secure { get; set; }
        public bool session { get; set; }
        public string storeId { get; set; }
        public string value { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            var expiryStr = (expirationDate >= 0 ? TimeUtils.FromSecondsSinceEpoch(expirationDate) : DateTime.MinValue).ToString(CultureInfo.InvariantCulture).ToUpper();
                
            var sameSiteStr = "Unspecified";
            if (sameSite.Contains("lax")) sameSiteStr = "Lax";
            if (sameSite.Contains("strict")) sameSiteStr = "Strict";

            return domain + "\t" + (!string.IsNullOrWhiteSpace(domain)).ToString(CultureInfo.InvariantCulture).ToUpper() + "\t" + path + "\t" + secure.ToString(CultureInfo.InvariantCulture).ToUpper() + "\t" +
                    expiryStr.ToString(CultureInfo.InvariantCulture).ToUpper() +
                    "\t" + name + "\t" + value + "\t" + httpOnly.ToString(CultureInfo.InvariantCulture).ToUpper() + "\t" +
                    (expirationDate < 0.01).ToString(CultureInfo.InvariantCulture).ToUpper()  + "\t" + sameSiteStr + "\t" + "Medium";

        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
