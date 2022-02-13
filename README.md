# TariffComparison

The **TariffComparison** is an API to compare products based on their annual costs. 
Built with the target framework **.Net Core 3.1** .

## Prerequisites
- .Net Core 3.1 has to be installed on the system.

## Launch
```sh
dotnet build
```
```sh
cd TariffComparison.API
```
```sh
dotnet run
```
Example Request:
```sh
curl --location --request GET "http://localhost:5000/api/product/3500"
```

