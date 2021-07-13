using Azihub.Utilities.Base.Extensions.String;
using Newtonsoft.Json;
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
            SetListFromBody();
            SanitizeList();
        }
        
        public IanaOrgTlds(string body, List<string> list)
        {
            Body = body;
            Hash = body.GetSha256();
            List = list;
            SanitizeList();
        }

        /// <summary>
        /// Used for json serialization only
        /// </summary>
        /// <param name="body"></param>
        /// <param name="hash"></param>
        /// <param name="count"></param>
        /// <param name="list"></param>
        public IanaOrgTlds(string body, string hash, uint count, List<string> list)
        {
            Body = body;
            Hash = hash;
            Count = count;
            List = list;
        }

        private void SetListFromBody()
        {
            List = Regex.Split(Body, "\r\n|\r|\n").ToList();
        }

        private void SanitizeList()
        {
            List.RemoveAll(x => x.ToUpper().Trim().StartsWith("#"));
            List.RemoveAll(x => String.IsNullOrEmpty(x));
        }

        /// <summary>
        /// Original string fetched from URL <see cref="TLDS_ALPHA_BY_DOMAIN_URL" />
        /// </summary>
        public string Body { get; private set; }


        /// <summary>
        /// Byte[] is stored as .txt file separately therefor ignored in .json file
        /// Original string fetched from URL <see cref="TLDS_ALPHA_BY_DOMAIN_URL" />
        /// </summary>
        [JsonIgnore]
        public byte[] Bytes { get; set; }

        /// <summary>
        /// Sha256 Hash of Body
        /// </summary>
        public string Hash { get; private set; }

#pragma warning disable IDE1006 // Naming Styles : overlap with 'Count' property
        private uint? _count { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        public uint Count 
        { 
            get
            {
                if (_count is null)
                    return (uint)(List is null ? 0 : List.Count());
                else
                    return (uint) _count;
            }
            private set
            {
                _count = value; 
            }
        }
        /// <summary>
        /// Parsed string into an enumerable  list array
        /// </summary>
        public List<string> List { get; private set; }
    }
}
