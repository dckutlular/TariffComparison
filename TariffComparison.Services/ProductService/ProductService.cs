using System.Collections.Generic;
using System.Linq;
using TariffComparison.Data.Helpers;
using TariffComparison.Data.Models.ProductModels;
using TariffComparison.Repository.ProductRepository;

namespace TariffComparison.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        /// <summary>
        /// Get the compared products with their names and annual costs
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public List<Product> GetComparedProducts(double consumption)
        {
            var tariffs = _productRepository.GetTariffs();

            return tariffs.Select(tariff => new Product()
            {
                AnnualCost = tariff.CalculateAnnualCost(consumption),
                TariffName = tariff.Type.GetDisplayName()
            })
                .OrderBy(x => x.AnnualCost)
                .ToList();
        }
    }
}
