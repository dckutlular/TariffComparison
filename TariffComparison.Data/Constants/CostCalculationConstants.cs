namespace TariffComparison.Data.Constants
{
    internal static class CostCalculationConstants
    {
        // Basic Tariff
        internal const decimal BasicTariffMonthlyBaseCost = 5.00m;
        internal const decimal BasicTariffUnitCostOfKwh = 0.22m;

        // Packaged Tariff
        internal const decimal PackagedTariffAnnualBaseCost = 800.00m;
        internal const decimal PackagedTariffUnitCostOfKwh = 0.30m;

        internal const double PackagedTariffConsumptionLimitInKwh = 4000;
    }
}
