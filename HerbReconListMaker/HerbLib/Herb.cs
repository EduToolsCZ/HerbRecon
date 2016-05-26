using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HerbLib
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Herb : ICloneable
    {
        private ulong _id;

        /// <summary>
        ///     The identification number of the herb, based on its Genus and Species
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public ulong Id
        {
            get
            {
                if (_id == 0) {
                    ResolveId();
                }
                return _id;
            }
        }

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
        public List<string> ImageUrls { get; set; }

        private void ResolveId()
        {
            _id = (ulong)(Genus.GetHashCode() & Species.GetHashCode());
        }

        public override string ToString()
        {
            return $"{Genus} {Species}";
        }

        public object Clone()
        {
            var h = new Herb
            {
                Genus = Genus,
                Species = Species,
                Family = Family,
                LatinName = LatinName,
                ImageUrls = new List<string>()
            };
            if (ImageUrls != null && ImageUrls.Count > 0)
                foreach (var imageUrl in ImageUrls) {
                    h.ImageUrls.Add(imageUrl);
                }
            return h;
        }
    }
}