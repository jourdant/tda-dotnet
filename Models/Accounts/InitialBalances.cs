namespace Jourdant.Tda.Models.Accounts
{
    public class InitialBalances
    {
        public double AccruedInterest { get; set; }
        public double CashAvailableForTrading { get; set; }
        public double CashAvailableForWithdrawal { get; set; }
        public double CashBalance { get; set; }
        public double BondValue { get; set; }
        public double CashReceipts { get; set; }
        public double LiquidationValue { get; set; }
        public double LongOptionMarketValue { get; set; }
        public double LongStockValue { get; set; }
        public double MoneyMarketFund { get; set; }
        public double MutualFundValue { get; set; }
        public double ShortOptionMarketValue { get; set; }
        public double ShortStockValue { get; set; }
        public bool IsInCall { get; set; }
        public double UnsettledCash { get; set; }
        public double CashDebitCallValue { get; set; }
        public double PendingDeposits { get; set; }
        public double AccountValue { get; set; }
    }
}