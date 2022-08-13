using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Nanoleaf.Client.Models.Responses
{
    public class GlobalOrientation
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }

        [JsonProperty("min")]
        public long Min { get; set; }
    }
}
