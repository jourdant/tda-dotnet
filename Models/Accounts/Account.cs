using System.Collections.Generic;
using Jourdant.Tda.Models.Instruments;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Jourdant.Tda.Models.Accounts
{
    public class Account 
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountType Type { get; set; }
        public string AccountId { get; set; }
        public int RoundTrips { get; set; }
        public bool IsDayTrader { get; set; }
        public bool IsClosingOnlyRestricted { get; set; }

        public List<Position> Positions { get; set; }
        //TODO: Implement OrderStrategies

        public InitialBalances InitialBalances { get; set; }
    }
}
