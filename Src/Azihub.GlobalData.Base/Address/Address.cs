using Azihub.GlobalData.Base.Country;
using Azihub.GlobalData.Base.Country.Interfaces;

namespace Azihub.GlobalData.Base.Address
{
    public abstract class Address<TCountryCode> where TCountryCode : CountryIso2Code
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public CountryIso2Code CountryIso2Code { get; set; }
    }
}
