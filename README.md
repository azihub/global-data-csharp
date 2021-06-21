# Global Data

- Countries
- Currencies (Fiat and Cyrpto)
- Banks


## Countries: `Azihub.GlobalData.Base.Country`
.NET built-in Country data also has many missing information such as an ENUM of strings to
get `ISO 3166-2` or `ISO 3166-3`

## Currencies: `Azihub.GlobalData.Base.Currency`
This project aim to solve the missing data within .NET existing globalization, for example,
number of decimal in currency is missing, or another example, the block of currency used for
displaying 100 YEN of Japan.

Also list of Cryptocurrencies combined with Fiat currencies:
- `ICurrency.cs`
- `CurrencyCrypto.cs`
- `CurrencyFiat.cs`

## Banks: `Azihub.GlobalData.Base.Banks`
List of banks by country, the website, IBAN support and variety of information
Also combining list of Central banks

- `Bank.cs`
- `CentralBank.cs`