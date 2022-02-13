using System.Collections.Generic;
using TariffComparison.Data.Models.ProductModels;

namespace TariffComparison.Services.ProductService
{
    public interface IProductService
    {
        List<Product> GetComparedProducts(double consumption);
    }
}
