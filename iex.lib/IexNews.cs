using Newtonsoft.Json;
using System;
using System.Net;
using System.Collections.Generic;

    public class IexNews : IexBase
    {
        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }

        public static List<IexNews> FromJson(string json) => JsonConvert.DeserializeObject<List<IexNews>>(json, JsonSettings);
    
        public static string ToJson(List<IexNews> items) => JsonConvert.SerializeObject(items, JsonSettings);
    
    }
