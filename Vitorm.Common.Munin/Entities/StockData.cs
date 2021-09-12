using System;
using System.Diagnostics;
using DvBCrud.EFCore.Entities;

namespace Vitorm.Common.Munin.Entities
{
    public class StockData : BaseEntity<int>
    {
        #region Prices
        
        public string Name { get; set; }
        
        public string Index { get; set; }
        
        public DateTimeOffset Timestamp { get; set; }
        
        /// <summary>
        /// Three-letter currency code as defined in ISO 4217
        /// </summary>
        public string CurrencyCode { get; set; }
        
        public decimal LatestPrice { get; set; }
        
        public decimal DeltaPrice { get; set; }
        
        public double DeltaPricePercent { get; set; }
        
        public decimal HighestPrice { get; set; }
        
        public decimal LowestPrice { get; set; }
        
        public ulong Volume { get; set; }
        
        public decimal MarketValue { get; set; }

        #endregion
        
        #region Key Performance Indicators

        public double PriceToEarningsRatio { get; set; }
        
        public double PriceToSalesRatio { get; set; }
        
        public double EarningsPerShare { get; set; }
        
        public double AdjustedEquityPerShare { get; set; }
        
        public decimal DividendYield { get; set; }
        
        public double DirectDividendPercent { get; set; }
        
        #endregion

        protected override void CopyImpl(BaseEntity<int> other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));
            if (!other.GetType().IsAssignableTo(GetType()))
                throw new ArgumentException($"{nameof(other)} is not assignable to {GetType().FullName}");
            
            var data = other as StockData;
            Debug.Assert(data != null, nameof(data) + " != null");
            
            Name = data.Name;
            Index = data.Index;
            Timestamp = data.Timestamp;
            CurrencyCode = data.CurrencyCode;
            LatestPrice = data.LatestPrice;
            DeltaPrice = data.DeltaPrice;
            DeltaPricePercent = data.DeltaPricePercent;
            HighestPrice = data.HighestPrice;
            LowestPrice = data.LowestPrice;
            Volume = data.Volume;
            MarketValue = data.MarketValue;

            PriceToEarningsRatio = data.PriceToEarningsRatio;
            PriceToSalesRatio = data.PriceToSalesRatio;
            EarningsPerShare = data.EarningsPerShare;
            AdjustedEquityPerShare = data.AdjustedEquityPerShare;
            DividendYield = data.DividendYield;
            DirectDividendPercent = data.DirectDividendPercent;
        }
    }
}