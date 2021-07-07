using Azihub.Utilities.Base.Extensions.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Azihub.GlobalData.Base.TopLevelDomain
{
    public class IanaOrgTlds
    {
        public const string TLDS_ALPHA_BY_DOMAIN_URL = "https://data.iana.org/TLD/tlds-alpha-by-domain.txt";
        
        public IanaOrgTlds(string body)
        {
            Body = body;
            Hash = body.GetSha256();
            List = Regex.Split(Body, "\r\n|\r|\n").ToList();
            List.RemoveAll(x => x.ToUpper().Trim().StartsWith("#"));
        }
        
        public IanaOrgTlds(string body, List<string> list)
        {
            Body = body;
            Hash = body.GetSha256();
            List = list;
        }

        [Obsolete("Illegal method", true)]
        public IanaOrgTlds(string body, string hash, uint count, List<string> list) 
        {
            Body = body;
            Hash = hash;
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
        

        public uint Count { get { return (uint)(List is null ? 0 : List.Count()); } }
        /// <summary>
        /// Parsed string into an enumerable  list array
        /// </summary>
        public List<string> List { get; }
    }
}
