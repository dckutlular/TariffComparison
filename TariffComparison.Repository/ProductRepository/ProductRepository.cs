using System.Collections.Generic;
using TariffComparison.Data.Models.TariffModels;

namespace TariffComparison.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        /// <summary>
        /// Get Tariffs
        /// </summary>
        /// <returns></returns>
        public List<Tariff> GetTariffs()
        {
            return new List<Tariff>
            {
                new BasicTariff(),
                new PackagedTariff()
            };
        }
    }
}
