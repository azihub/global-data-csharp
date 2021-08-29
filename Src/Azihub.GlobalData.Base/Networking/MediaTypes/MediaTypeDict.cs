using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azihub.GlobalData.Base.Networking.MediaTypes
{
    partial class MediaType
    {
        public static IList<MediaType> MimeList => MediaTypeDict.Values.ToList();

        private static readonly Dictionary<string, MediaType> MediaTypeDict = new Dictionary<string, MediaType>()
        {
                { MimeTypeConstants.JSON, new MediaType(MimeTypeConstants.JSON, new string[] { "json" },  new string[] {"[RFC8259]" }) },
                { MimeTypeConstants.TXT, new MediaType(MimeTypeConstants.TXT, new string[] { "txt" },  new string[] {"[RFC2046]","[RFC3676]","[RFC5147]" }) }
        };
    }
}
