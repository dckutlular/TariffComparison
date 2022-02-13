using TariffComparison.Data.Enums;

namespace TariffComparison.Data.Models.TariffModels
{
    /// <summary>
    /// Abstract Base class since all tariffs have the following properties and method with specific implementations.
    /// </summary>
    public abstract class Tariff
    {
        public abstract TariffType Type { get; }
        public abstract decimal BaseCost { get;  }
        public abstract decimal UnitCostOfKwh { get;  }
        public abstract decimal CalculateAnnualCost(double consumption);
    }
}
