namespace Jourdant.Tda.Models.Instruments
{
    public partial class Position
    {
        public int ShortQuantity { get; set; }
        public double AveragePrice { get; set; }
        public double CurrentDayProfitLoss { get; set; }
        public double CurrentDayProfitLossPercentage { get; set; }
        public int LongQuantity { get; set; }
        public int SettledLongQuantity { get; set; }
        public int SettledShortQuantity { get; set; }
        public int AgedQuantity { get; set; }
        public InstrumentType Instrument { get; set; }
        public double MarketValue { get; set; }
    }
}