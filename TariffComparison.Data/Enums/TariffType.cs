using System.ComponentModel.DataAnnotations;
using TariffComparison.Data.Constants;

namespace TariffComparison.Data.Enums
{
    public enum TariffType
    {
        [Display(Name = TariffConstants.BasicTariffName)]
        Basic = 1,

        [Display(Name = TariffConstants.PackagedTariffName)]
        Packaged = 2
    }
}
