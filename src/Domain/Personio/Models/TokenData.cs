﻿using Newtonsoft.Json;

namespace Moeller.Toggl.Cli.Domain.Personio.Models
{
    public class TokenData
    {
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
    }
}
