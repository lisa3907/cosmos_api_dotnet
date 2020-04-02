﻿using CosmosApi.Serialization;
using Newtonsoft.Json;

namespace CosmosApi.Models
{
    /// <summary>
    /// MsgSend - high level transaction of the coin module.
    /// </summary>
    public class MsgSend : IMsg
    {
        [JsonProperty("from_address")]
        public byte[] FromAddress { get; set; }
        
        [JsonProperty("to_address")]
        public byte[] ToAddress { get; set; }
    }
}