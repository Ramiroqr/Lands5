using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lands5.Models
{
    public class Language
    {
        [JsonProperty(PropertyName = "iso6391")]
        public string Iso6391 { get; set; }
        [JsonProperty(PropertyName = "iso6392")]
        public string Iso6392 { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "nativeName")]
        public string NativeName { get; set; }
    }
}
