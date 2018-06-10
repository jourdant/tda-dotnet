using Jourdant.Tda.Models.Options;
using Newtonsoft.Json;

namespace Jourdant.Tda.Models.Instruments
{
    public class OptionInstrument : Instrument
    {
        [JsonProperty("type")]
        public OptionType Type { get; set; }
        public OptionDirection PutCall { get; set; }
        public string UnderlyingSymbol { get; set; }
        public double OptionMultiplier { get; set; }

        //TODO: Add option deliverables
    }
}
