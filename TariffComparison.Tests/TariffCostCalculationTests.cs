using System.Collections.Generic;
using TariffComparison.Data.Models.ProductModels;
using TariffComparison.Repository.ProductRepository;
using TariffComparison.Services.ProductService;
using Xunit;
using Newtonsoft.Json;

namespace TariffComparison.Tests
{
    public class TariffCostCalculationTests
    {
        private readonly IProductRepository _productRepository = new ProductRepository();
        private readonly IProductService _productService;

        public TariffCostCalculationTests()
        {
            _productService = new ProductService(_productRepository);
        }

        [Theory]
        [InlineData(0)]
        public void CalculateAnnualCostsWith0(double consumption)
        {
            // Arrange
            var expectedResult = new List<Product>
            {
                new Product
                {
                    AnnualCost = 60.00m,
                    TariffName = "Basic Electricity Tariff"
                },
                new Product
                {
                    AnnualCost = 800.00m,
                    TariffName = "Packaged Tariff"
                }
            };

            // Act
            var actualResult = _productService.GetComparedProducts(consumption);

            // Assert --> since equal is related to reference I used serialization as a workaround
            Assert.Equal(JsonConvert.SerializeObject(expectedResult), JsonConvert.SerializeObject(actualResult));
        }

        [Theory]
        [InlineData(3500)]
        public void CalculateAnnualCostsWith3500(double consumption)
        {
            // Arrange
            var expectedResult = new List<Product>
            {
                new Product
                {
                    AnnualCost = 800.00m,
                    TariffName = "Packaged Tariff"
                },
                new Product
                {
                    AnnualCost = 830.00m,
                    TariffName = "Basic Electricity Tariff"
                }
            };

            // Act
            var actualResult = _productService.GetComparedProducts(consumption);

            // Assert --> since equal is related to reference I used serialization as a workaround
            Assert.Equal(JsonConvert.SerializeObject(expectedResult), JsonConvert.SerializeObject(actualResult));
        }

        [Theory]
        [InlineData(4500)]
        public void CalculateAnnualCostsWith4500(double consumption)
        {
            // Arrange
            var expectedResult = new List<Product>
            {
                new Product
                {
                    AnnualCost = 950.00m,
                    TariffName = "Packaged Tariff"
                },
                new Product
                {
                    AnnualCost = 1050.00m,
                    TariffName = "Basic Electricity Tariff"
                }
            };

            // Act
            var actualResult = _productService.GetComparedProducts(consumption);

            // Assert --> since equal is related to reference I used serialization as a workaround
            Assert.Equal(JsonConvert.SerializeObject(expectedResult), JsonConvert.SerializeObject(actualResult));
        }

        [Theory]
        [InlineData(6000)]
        public void CalculateAnnualCostsWith6000(double consumption)
        {
            // Arrange
            var expectedResult = new List<Product>
            {
                new Product
                {
                    AnnualCost = 1380.00m,
                    TariffName = "Basic Electricity Tariff"
                },
                new Product
                {
                    AnnualCost = 1400.00m,
                    TariffName = "Packaged Tariff"
                }
            };

            // Act
            var actualResult = _productService.GetComparedProducts(consumption);

            // Assert --> since equal is related to reference I used serialization as a workaround
            Assert.Equal(JsonConvert.SerializeObject(expectedResult), JsonConvert.SerializeObject(actualResult));
        }
    }
}
