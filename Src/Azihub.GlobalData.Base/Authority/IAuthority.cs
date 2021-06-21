namespace Azihub.GlobalData.Base.Authority
{
    public interface IAuthorityCode
    {
        public string Code { get; set; }
    }

    public interface IAuthority
    {
        public string Name { get; set; }
        /// <summary>
        /// Two Letter code assignment of authority or region
        /// </summary>
        public IAuthorityCode AuthorityCode { get; set; }
        public Type Type { get; set; }
    }

    public enum Type
    {
        AutonomousTerritory,
        /// <summary>
        /// 
        /// </summary>
        GovernmentCountry,
        /// <summary>
        /// Inspired by https://en.wikipedia.org/wiki/List_of_country_groupings
        /// </summary>
        CountryGrouping
    }
}
