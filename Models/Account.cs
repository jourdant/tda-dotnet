using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Jourdant.Tda.Models 
{
    public class Account 
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountType Type { get; set; }
        public string AccountId { get; set; }
        public int RoundTrips { get; set; }
        public bool IsDayTrader { get; set; }
        public bool IsClosingOnlyRestricted { get; set; }

        //positions
        //orderstrategies
        public InitialBalances InitialBalances { get; set; }
    }
}
