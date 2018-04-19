namespace Lands.Models
{
    using Newtonsoft.Json;
    using System;
    public class RegionalBloc
    {
        [JsonProperty(PropertyName = "acronym")]
        public string Acronym { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
