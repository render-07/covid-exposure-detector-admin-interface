using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBLibrary
{
    public class NewsApiModel
    {
        [JsonProperty(PropertyName = "author")]
        public string author { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string description { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string url { get; set; }

        [JsonProperty(PropertyName = "urlToImage")]
        public string urlToImage { get; set; }

        [JsonProperty(PropertyName = "publishedAt")]
        public DateTime publishedAt { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string content { get; set; }
    }
}

