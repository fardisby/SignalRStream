namespace SignalRStream
{
    public class PriceInfo
    {
        public string Symbol { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Symbol}: ${Price}";
        }

    }
}

