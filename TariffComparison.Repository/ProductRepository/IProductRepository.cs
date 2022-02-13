using System.Collections.Generic;
using TariffComparison.Data.Models.TariffModels;

namespace TariffComparison.Repository.ProductRepository
{
    public interface IProductRepository
    {
        List<Tariff> GetTariffs();
    }
}
