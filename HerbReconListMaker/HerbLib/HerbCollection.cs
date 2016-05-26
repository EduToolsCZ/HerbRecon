using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HerbLib
{
    [JsonObject(MemberSerialization.OptIn)]
    public class HerbCollection : ICloneable
    {
        public HerbCollection()
        {
            Herbs = new List<Herb>();
        }

        [JsonProperty(PropertyName = "herbs")]
        public List<Herb> Herbs { get; set; }

        public object Clone()
        {
            var hc = new HerbCollection();
            foreach (var herb in Herbs)
            {
                hc.Herbs.Add((Herb)herb.Clone());
            }
            return hc;
        }
    }
}