using Newtonsoft.Json;

namespace HerbLib
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Herb
    {
        /// <summary>
        ///     Unique identification number of the herb
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public ulong Id { get; set; }

        /// <summary>
        ///     The genus of the herb (rod)
        /// </summary>
        [JsonProperty(PropertyName = "genus")]
        public string Genus { get; set; }

        /// <summary>
        ///     The species of the herb (druh)
        /// </summary>
        [JsonProperty(PropertyName = "species")]
        public string Species { get; set; }

        /// <summary>
        ///     The latin name of the herb
        /// </summary>
        [JsonProperty(PropertyName = "latinName")]
        public string LatinName { get; set; }

        /// <summary>
        ///     The family of the herb (čeleď)
        /// </summary>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        ///     The collection of image URLs for the herb
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public string[] ImageUrls { get; set; }
    }
}