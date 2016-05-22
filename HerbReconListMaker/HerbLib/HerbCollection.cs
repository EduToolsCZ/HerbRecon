using System.Collections.Generic;
using Newtonsoft.Json;

namespace HerbLib
{
    [JsonObject(MemberSerialization.OptIn)]
    public class HerbCollection
    {
        public HerbCollection()
        {
            Herbs = new List<Herb>();
        }

        [JsonProperty(PropertyName = "herbs")]
        public List<Herb> Herbs { get; set; }
    }
}