using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HerbLib
{
    /// <summary>
    ///     Represents a herb
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Herb : ICloneable
    {
        private uint _id;

        /// <summary>
        ///     The identification number of the herb, based on its Genus and Species
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public uint Id
        {
            get
            {
                if (_id == 0)
                {
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
                foreach (var imageUrl in ImageUrls)
                {
                    h.ImageUrls.Add(imageUrl);
                }
            return h;
        }

        /// <summary>
        ///     Computes the ID of the herb from its genus and species properties
        /// </summary>
        private void ResolveId()
        {
            int genusCode = 0, speciesCode = 0;
            if (!string.IsNullOrWhiteSpace(Genus)) genusCode = Genus.GetHashCode();
            if (!string.IsNullOrWhiteSpace(Species)) speciesCode = Species.GetHashCode();
            _id = (uint) (genusCode & speciesCode);
        }

        public override string ToString()
        {
            return $"{Genus} {Species}";
        }
    }
}