using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Azihub.GlobalData.Base.TopLevelDomain.Tools
{
    public class IanaOrgTldsConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // load the object 
            JObject jObject = JObject.Load(reader);
            string body = jObject.GetValue(nameof(IanaOrgTlds.Body)).ToString();
            string hash = jObject.GetValue(nameof(IanaOrgTlds.Hash)).ToString();
            uint count = (uint) jObject.GetValue(nameof(IanaOrgTlds.Count));
            var list = jObject.GetValue(nameof(IanaOrgTlds.List)).ToObject<List<string>>();
            return new IanaOrgTlds(body, hash, count, list);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
