using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HerbLib
{
    /// <summary>
    ///     Represents a Herb collection, used for Json serialization
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HerbCollection : ICloneable
    {
        public HerbCollection()
        {
            Herbs = new List<Herb>();
        }

        /// <summary>
        ///     The collection of herbs
        /// </summary>
        [JsonProperty(PropertyName = "herbs")]
        public List<Herb> Herbs { get; set; }

        public object Clone()
        {
            var hc = new HerbCollection();
            foreach (var herb in Herbs)
            {
                hc.Herbs.Add((Herb) herb.Clone());
            }
            return hc;
        }
    }
}