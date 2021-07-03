using Azihub.Utilities.Base.Extensions.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azihub.GlobalData.Base.TopLevelDomain
{
    public class IanaOrgTlds
    {
        public const string TLDS_ALPHA_BY_DOMAIN_URL = "https://data.iana.org/TLD/tlds-alpha-by-domain.txt";
        public IanaOrgTlds(string body, List<string> list)
        {
            Body = body;
            Hash = body.GetSha256();
            List = list;
        }

        /// <summary>
        /// Original string fetched from URL <see cref="TLDS_ALPHA_BY_DOMAIN_URL" />
        /// </summary>
        public string Body { get; }
        
        /// <summary>
        /// Sha256 Hash of Body
        /// </summary>
        public string Hash { get; }
        

        public uint Count { get { return (uint) List.Count(); } }
        /// <summary>
        /// Parsed string into an enumerable  list array
        /// </summary>
        public IEnumerable<string> List { get; }
    }
}
