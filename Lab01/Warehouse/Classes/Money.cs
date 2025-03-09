using System;

namespace ClassLibrary
{
    public class Money
    {
        protected int wholePart;
        protected int fractionalPart;
        protected string currency;

        public int WholePart => wholePart; 
        public int FractionalPart => fractionalPart;
        public string Currency => currency;

        public static readonly Dictionary<string, double> ExchangeRates = new()
        {
            { "UAH", 1.0 },
            { "USD", 42.0 },
            { "EUR", 43.8 }
        };
        public Money(int wholePart, int fractionalPart, string currency)
        {
            if (!ExchangeRates.ContainsKey(currency))
                throw new ArgumentException($"Unsupported currency: {currency}");

            this.currency = currency;
            SetMoney(wholePart, fractionalPart);
        }

        public void SetMoney(int whole, int fractional)
        {
            if (fractional >= 100)
            {
                whole += fractional / 100;
                fractional %= 100;
            }

            this.wholePart = whole;
            this.fractionalPart = fractional;
        }

        public double ConvertToCurrency(string targetCurrency)
        {
            if (!ExchangeRates.ContainsKey(targetCurrency))
                throw new ArgumentException($"Unsupported target currency: {targetCurrency}");

            double amountInSourceCurrency = wholePart + fractionalPart / 100.0;

            double conversionRate = ExchangeRates[currency] / ExchangeRates[targetCurrency];
            
            return amountInSourceCurrency * conversionRate;
        }
    }

    public class USD : Money
    {
        public USD(int whole, int fractional) : base(whole, fractional, "USD") { }
    }

    public class EUR : Money
    {
        public EUR(int whole, int fractional) : base(whole, fractional, "EUR") { }
    }

    public class UAH : Money
    {
        public UAH(int whole, int fractional) : base(whole, fractional, "UAH") { }
    }
}
