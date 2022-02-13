using TariffComparison.Data.Constants;
using TariffComparison.Data.Enums;
using TariffComparison.Data.Helpers;

namespace TariffComparison.Data.Models.TariffModels
{
    public class PackagedTariff : Tariff
    {
        public override TariffType Type => TariffType.Packaged;
        public override decimal BaseCost => CostCalculationConstants.PackagedTariffAnnualBaseCost;
        public override decimal UnitCostOfKwh => CostCalculationConstants.PackagedTariffUnitCostOfKwh;
        // Limit is spesific to Packaged Tariff
        private static double ConsumptionLimit => CostCalculationConstants.PackagedTariffConsumptionLimitInKwh;

        /// <summary>
        /// Implementation of Annual Cost Calculation of Packaged Tariff
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public override decimal CalculateAnnualCost(double consumption)
        {
            return consumption < ConsumptionLimit
                ? BaseCost
                : BaseCost + UnitCostOfKwh * (consumption - ConsumptionLimit).ToDecimal();
        }
    }
}
