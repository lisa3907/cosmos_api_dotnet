using Newtonsoft.Json;

namespace CosmosApi.Models
{
    public class StdTxSignaturePubKey
    {
        /// <summary>
        /// Initializes a new instance of the StdTxSignaturePubKey class.
        /// </summary>
        public StdTxSignaturePubKey()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StdTxSignaturePubKey class.
        /// </summary>
        public StdTxSignaturePubKey(string type = default, string value = default)
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
