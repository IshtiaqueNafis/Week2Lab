using System.Globalization;

namespace Week2Lab
{
    public class TripCalculator
    {
        public string Name { get; set; }
        public double GasMile { get; set; }
        public double GasPrice { get; set; }

        private double Calculate => GasMile * GasPrice;

        public override string ToString()
        {
            return (GasMile * GasPrice).ToString(CultureInfo.InvariantCulture);
        }
    }
}