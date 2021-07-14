using Azihub.Utilities.Base.Extensions.String;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            SetVersionUpdate();
        }

        public IanaOrgTlds(string body, List<string> list, byte[] bytes)
        {
            Body = body;
            Bytes = bytes;
            List = list;
            Hash = body.GetSha256();
            SanitizeList();
            SetVersionUpdate();
        }

        /// <summary>
        /// Used for json serialization only
        /// </summary>
        /// <param name="body"></param>
        /// <param name="hash"></param>
        /// <param name="count"></param>
        /// <param name="list"></param>
        public IanaOrgTlds(string body, string hash, uint count, List<string> list, string version, string lastUpdate)
        {
            Body = body;
            Hash = hash;
            Count = count;
            _count = count;
            List = list;
            Version = version;
            LastUpdate = DateTime.Parse(lastUpdate);
        }

        private void SetVersionUpdate()
        {
            const string regexPatternHeader = @"Version (?<version>\d{1,}), Last Updated (?<LastUpdate>.*UTC)";
            var result = Regex.Match(Body, regexPatternHeader, RegexOptions.IgnoreCase).Groups;
            Version = result["version"].Value;
            const string regexPatternLastUpdate = @"ddd MMM dd hh:mm:ss yyyy UTC"; // Jul 12 07:07:02 2021 UTC"
            LastUpdate = DateTime.ParseExact(result["LastUpdate"].Value,
                regexPatternLastUpdate,
                CultureInfo.InvariantCulture,
                DateTimeStyles.AllowWhiteSpaces);
            //const string regexPatternDate = @"(?<month>\w\w\w) (?<day>\d\d) (?<hour>\d\d):(?<minute>\d\d):(?<second>\d\d) (?<year>\d{4,4})";
            //var groups = Regex.Match(Body, regexPatternDate, RegexOptions.IgnoreCase).Groups;
            //LastUpdate = new DateTime(
            //    int.Parse(groups["year"].Value),
            //    ,
            //    int.Parse(groups["day"].Value),
            //    int.Parse(groups["hour"].Value),
            //    int.Parse(groups["minute"].Value),
            //    int.Parse(groups["second"].Value)
            //    ); 
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
        /// Tld Version as per first line  Version 2021071200
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Tld last update (Date Fromat RFC 1123) as per first line in file: Last Updated Mon Jul 12 07:07:02 2021 UTC
        /// </summary>
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Byte[] is stored as .txt file separately therefor ignored in .json file
        /// Original string fetched from URL <see cref="TLDS_ALPHA_BY_DOMAIN_URL" />
        /// </summary>
        [JsonIgnore]
        public byte[] Bytes { get; set; } = Array.Empty<byte>();

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
                    return (uint)_count;
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
