namespace Azihub.GlobalData.Base.Authority
{
    public interface IAuthorityCode
    {
        string Code { get; set; }
    }

    public interface IAuthority
    {
        string Name { get; set; }
        /// <summary>
        /// Two Letter code assignment of authority or region
        /// </summary>
        IAuthorityCode AuthorityCode { get; set; }
        Type Type { get; set; }
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
