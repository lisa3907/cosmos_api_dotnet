using System;
using System.Collections.Generic;
using CosmosApi.Serialization;
using Newtonsoft.Json;

namespace CosmosApi.Models
{
    public class BroadcastTxResult
    {
        /// <summary>
        /// Initializes a new instance of the BroadcastTxResult class.
        /// </summary>
        public BroadcastTxResult()
        {
        }

        public BroadcastTxResult(string txHash = null, int? height = default, string? rawLog = null, IList<ABCIMessageLog> logs = null, ulong gasWanted = default, ulong gasUsed = default, IList<StringEvent> events = null)
        {
            TxHash = txHash;
            Height = height;
            RawLog = rawLog;
            Logs = logs;
            GasWanted = gasWanted;
            GasUsed = gasUsed;
            Events = events;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "txhash")]
        public string TxHash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        [JsonProperty(PropertyName = "raw_log")]
        public string? RawLog { get; set; }
        
        [JsonProperty("logs")]
        public IList<ABCIMessageLog> Logs { get; set; } 
        
        [JsonProperty("gas_wanted")]
        [JsonConverter(typeof(StringNumberConverter))]
        public ulong GasWanted { get; set; }

        [JsonProperty("gas_used")]
        [JsonConverter(typeof(StringNumberConverter))]
        public ulong GasUsed { get; set; }

        [JsonProperty(PropertyName = "events")]
        public IList<StringEvent> Events { get; set; }
    }
}
