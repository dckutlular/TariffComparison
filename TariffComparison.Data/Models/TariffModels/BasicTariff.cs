using TariffComparison.Data.Constants;
using TariffComparison.Data.Enums;
using TariffComparison.Data.Helpers;

namespace TariffComparison.Data.Models.TariffModels
{
    public class BasicTariff : Tariff
    {
        public override TariffType Type => TariffType.Basic;
        public override decimal BaseCost => CostCalculationConstants.BasicTariffMonthlyBaseCost;
        public override decimal UnitCostOfKwh => CostCalculationConstants.BasicTariffUnitCostOfKwh;

        /// <summary>
        /// Implementation of Annual Cost Calculation of Basic Electricity Tariff
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public override decimal CalculateAnnualCost(double consumption)
        {
            return BaseCost.ToAnnualCost() + UnitCostOfKwh * consumption.ToDecimal();
        }
    }
}
