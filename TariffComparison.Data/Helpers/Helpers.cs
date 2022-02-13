using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace TariffComparison.Data.Helpers
{
    public static class Helpers
    {
        /// <summary>
        /// Get the display name property of enum
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
              .GetMember(enumValue.ToString())
              .First()
              .GetCustomAttribute<DisplayAttribute>()
              ?.GetName();
        }

        /// <summary>
        /// Conversion of monthly cost to annual cost
        /// </summary>
        /// <param name="monthlyCost"></param>
        /// <returns></returns>
        public static decimal ToAnnualCost(this decimal monthlyCost)
        {
            return monthlyCost * 12;
        }

        /// <summary>
        /// Convert double to decimal
        /// </summary>
        /// <param name="doubleValue"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this double doubleValue)
        {
            return Convert.ToDecimal(doubleValue);
        }
    }
}
